import { Module } from '@nestjs/common';
import { DoctorController } from './doctor.controller';
import { DoctorService } from './doctor.service';
import { Doctor } from 'src/patient/doctor.entity';
import { TypeOrmModule } from '@nestjs/typeorm';

@Module({
  imports:[TypeOrmModule.forFeature([Doctor])],
  controllers: [DoctorController],
  providers: [DoctorService]
})
export class DoctorModule {}
