import { Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Patient } from 'src/patient/patient.entity';
import { Repository } from 'typeorm';
import { NotFoundException } from '@nestjs/common'; // Import NotFoundException

@Injectable()
export class ProfileService {
  constructor(
    @InjectRepository(Patient) private readonly patientRepository: Repository<Patient>,
  ) {}

  // Fetch the full user details by phone number
  async getPatientByPhoneNumber(phone_number: string) {
    const patient = await this.patientRepository.findOne({ where: { phone_number },
    select:['full_name','date_of_birth','email','insurance_number','password','phone_number']
    });

    if (!patient) {
      throw new NotFoundException('Patient not found'); // Throw NotFoundException instead of generic error
    }

    return patient; // Return patient details
  }
}
