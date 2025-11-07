import { Module } from '@nestjs/common';
import { FeedbackController } from './feedback.controller';
import { FeedbackService } from './feedback.service';
import { Feedback } from 'src/patient/feedback.entity';
import { TypeOrmModule } from '@nestjs/typeorm';
import { Patient } from 'src/patient/patient.entity';

@Module({
  imports:[TypeOrmModule.forFeature([Feedback,Patient])],
  controllers: [FeedbackController],
  providers: [FeedbackService]
})
export class FeedbackModule {}
