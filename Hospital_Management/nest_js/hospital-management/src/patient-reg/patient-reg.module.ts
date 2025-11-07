import { Module } from '@nestjs/common';
import { PatientRegController } from './patient-reg.controller';
import { PatientRegService } from './patient-reg.service';
import { Patient } from 'src/patient/patient.entity';
import { TypeOrmModule } from '@nestjs/typeorm';

@Module({
  imports:[TypeOrmModule.forFeature([Patient])],
  controllers: [PatientRegController],
  providers: [PatientRegService]
})
export class PatientRegModule {}
