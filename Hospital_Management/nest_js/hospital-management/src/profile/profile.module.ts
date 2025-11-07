import { Module } from '@nestjs/common';
import { ProfileController } from './profile.controller';
import { ProfileService } from './profile.service';
import { Patient } from 'src/patient/patient.entity';
import { TypeOrmModule } from '@nestjs/typeorm';

@Module({
  imports:[TypeOrmModule.forFeature([Patient])],
  controllers: [ProfileController],
  providers: [ProfileService]
})
export class ProfileModule {}
