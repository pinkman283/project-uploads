import { Body, Controller, Post, ValidationPipe } from '@nestjs/common';
import { PatientRegService } from './patient-reg.service';
import { check } from './dto/check.dto';
import { check2 } from 'src/appoinment/dto/check2.dto';

@Controller('patient-reg')
export class PatientRegController {
  constructor(private readonly patientRegService: PatientRegService) {}

  @Post('send-otp')
  async sendOtp(@Body(new ValidationPipe()) ab: check) {
    return this.patientRegService.sendOtp(ab);
  }

  @Post('verify-otp')
  async verifyOtp(
    @Body('email') email: string,
    @Body('otp') otp: string,
    @Body() ab: check2,
  ) {
    return this.patientRegService.verifyOtpAndRegister(email, otp, ab);
  }
}
