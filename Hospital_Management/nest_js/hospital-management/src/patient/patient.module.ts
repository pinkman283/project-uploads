import { Module } from '@nestjs/common';
import { PatientController } from './patient.controller';
import { PatientService } from './patient.service';
import { Patient } from './patient.entity';
import { TypeOrmModule } from '@nestjs/typeorm';
import { JwtModule } from '@nestjs/jwt';
import { PassportModule } from '@nestjs/passport';
import { JwtStrategy } from './jwt.strategy';

@Module({
  imports:[TypeOrmModule.forFeature([Patient]),
  PassportModule,
  JwtModule.register({
    secret: 'key1', 
    signOptions: { expiresIn: '1h' }, 
  }),
],
  controllers: [PatientController],
  providers: [PatientService,JwtStrategy],
  exports: [JwtModule, PassportModule], 
})
export class PatientModule {}
