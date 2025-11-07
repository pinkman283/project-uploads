import { Module } from '@nestjs/common';
import { AppController } from './app.controller';
import { AppService } from './app.service';
import { PatientModule } from './patient/patient.module';
import { FeedbackModule } from './feedback/feedback.module';
import { ProfileModule } from './profile/profile.module';
import { TypeOrmModule } from '@nestjs/typeorm';
import { Patient } from './patient/patient.entity';
import { PatientRegModule } from './patient-reg/patient-reg.module';
import { DoctorModule } from './doctor/doctor.module';
import { Doctor } from './patient/doctor.entity';
import { Appointment } from './patient/appoinment.entity';
import { AppoinmentModule } from './appoinment/appoinment.module';
import { Feedback } from './patient/feedback.entity';
import { MedicalRecordModule } from './medical-record/medical-record.module';
import { MedicalRecord } from './medical-record/medical-record.entity';
import { MailerModule } from '@nestjs-modules/mailer';
import { HandlebarsAdapter } from '@nestjs-modules/mailer/dist/adapters/handlebars.adapter';

@Module({
  imports: [
    PatientModule,
    ProfileModule,
    TypeOrmModule.forRoot({
      type: 'postgres',
      host: 'localhost',
      port: 5432,
      username: 'postgres',
      password: 'root',
      database: 'hospital-management',
      entities: [Patient, Doctor, Appointment, Feedback, MedicalRecord],
      synchronize: true,
    }),
    MailerModule.forRoot({
      transport: {
        host: 'smtp.gmail.com',
        port: 587,
        secure: false,
        auth: {
          user: 'shovonshihab283@gmail.com',          
          pass: 'ojgx lfbk gkvi pjuw',        
        },
      },
      defaults: {
        from: '"Hospital Admin" <shovonshihab283@gmail.com>', 
      },
    }),
    PatientRegModule,
    DoctorModule,
    FeedbackModule,
    AppoinmentModule,
    MedicalRecordModule,
  ],
  controllers: [AppController],
  providers: [AppService],
})
export class AppModule {}
