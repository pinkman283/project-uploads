import { Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Patient } from 'src/patient/patient.entity';
import { Repository } from 'typeorm';
import { MailerService } from '@nestjs-modules/mailer';
import { HttpException, HttpStatus } from '@nestjs/common'; // Import for HttpException and HttpStatus

@Injectable()
export class PatientRegService {
  private otpStorage: Map<string, { otp: string; createdAt: number }> = new Map(); // email -> { OTP, createdAt }

  constructor(
    @InjectRepository(Patient)
    private myRepo: Repository<Patient>,
    private readonly mailerService: MailerService,
  ) {}

  // Send OTP to the user's email if no duplicates
  async sendOtp(ab) {
    const existingEmail = await this.myRepo.findOne({
      where: { email: ab.email },
    });
    if (existingEmail) {
      throw new HttpException('Email already registered', HttpStatus.CONFLICT); // 409 Conflict
    }

    const existingPhone = await this.myRepo.findOne({
      where: { phone_number: ab.phone_number },
    });
    if (existingPhone) {
      throw new HttpException('Phone number already registered', HttpStatus.CONFLICT); // 409 Conflict
    }

    const existingInsurance = await this.myRepo.findOne({
      where: { insurance_number: ab.insurance_number },
    });
    if (existingInsurance) {
      throw new HttpException('Insurance number already registered', HttpStatus.CONFLICT); // 409 Conflict
    }

    // Proceed to generate OTP
    const otp = Math.floor(100000 + Math.random() * 900000).toString(); // 6-digit OTP
    this.otpStorage.set(ab.email, { otp, createdAt: Date.now() });

    await this.mailerService.sendMail({
      to: ab.email,
      subject: 'Your OTP for Registration',
      text: `Your OTP is: ${otp}`,
    });

    return { message: 'OTP sent to your email' }; // OTP sent successfully
  }

  // Verify OTP and register the user
  async verifyOtpAndRegister(email: string, otp: string, ab) {
    const storedOtpData = this.otpStorage.get(email);

    if (!storedOtpData) {
      throw new HttpException('Invalid or expired OTP', HttpStatus.BAD_REQUEST); // 400 Bad Request
    }

    const currentTime = Date.now();
    const otpExpirationTime = 5 * 60 * 1000; // 5 minutes in milliseconds
    if (currentTime - storedOtpData.createdAt > otpExpirationTime) {
      this.otpStorage.delete(email);
      throw new HttpException('OTP has expired. Please request a new one.', HttpStatus.BAD_REQUEST); // 400 Bad Request
    }

    if (storedOtpData.otp !== otp) {
      throw new HttpException('Invalid OTP', HttpStatus.BAD_REQUEST); // 400 Bad Request
    }

    const existingPatient = await this.myRepo.findOne({
      where: [
        { phone_number: ab.phone_number },
        { insurance_number: ab.insurance_number },
        { email: ab.email },
      ],
    });

    if (existingPatient) {
      throw new HttpException('Patient already exists', HttpStatus.CONFLICT); // 409 Conflict
    }

    const savedPatient = await this.myRepo.save(ab);
    this.otpStorage.delete(email);

    if (savedPatient) {
      return { message: 'User registered successfully!' };
    } else {
      throw new HttpException('Registration unsuccessful', HttpStatus.INTERNAL_SERVER_ERROR); // 500 Internal Server Error
    }
  }
}
