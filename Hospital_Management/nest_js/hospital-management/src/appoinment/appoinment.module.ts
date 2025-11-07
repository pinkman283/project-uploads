import { Module } from '@nestjs/common';
import { AppoinmentController } from './appoinment.controller';
import { AppoinmentService } from './appoinment.service';
import { Appointment } from 'src/patient/appoinment.entity';
import { TypeOrmModule } from '@nestjs/typeorm';
import { Patient } from 'src/patient/patient.entity';
import { Doctor } from 'src/patient/doctor.entity';

@Module({
  imports:[TypeOrmModule.forFeature([Appointment,Patient,Doctor])],
  controllers: [AppoinmentController],
  providers: [AppoinmentService]
})
export class AppoinmentModule {}
