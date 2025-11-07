import { Injectable } from '@nestjs/common';
import { Patient } from './patient.entity';
import { Repository } from 'typeorm';
import { InjectRepository } from '@nestjs/typeorm';
import { JwtService } from '@nestjs/jwt';

@Injectable()
export class PatientService {
  constructor(
    @InjectRepository(Patient) private myRepo: Repository<Patient>,
    private jwtservice: JwtService
  ) {}

  async login(ab) {
    // Look for a user with the provided phone number and password
    const checkPatient = await this.myRepo.findOne({
      where: {
        phone_number: ab.phone_number,
        password: ab.password, // Ensure this is comparing the plain-text password
      },
    });

    // If the patient exists
    if (checkPatient) {
      const payload = {
        sub: checkPatient.id,  // User's ID (used as subject for the token)
        phone_number: checkPatient.phone_number,  // User's phone number
        full_name: checkPatient.full_name,  // User's full name
      };
      
      // Generate JWT token
      const token = this.jwtservice.sign(payload);

      // Return the token and user data in the response
      return {
        token,
        message: 'Login successful',
        user: {
          name: checkPatient.full_name,
          phone_number: checkPatient.phone_number,
        },
      };
    } else {
      // If no user is found
      return { message: 'User not found or invalid credentials' };  
    }
  }
}
