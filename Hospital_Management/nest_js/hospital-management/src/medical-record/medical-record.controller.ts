import { Body, Controller, Get, Param, Post, Res, UseGuards, ValidationPipe } from '@nestjs/common';
import { MedicalRecordService } from './medical-record.service';
import { AuthGuard } from '@nestjs/passport';
import { Response } from 'express';


@Controller('medical-record')
export class MedicalRecordController {
    constructor(private readonly mediserv: MedicalRecordService) {}

    @UseGuards(AuthGuard('jwt'))
    @Get(':phone_number') 
    getPatient(@Param('phone_number') phone_number: string) {
        return this.mediserv.getPatient(phone_number);
    }


      @UseGuards(AuthGuard('jwt'))
    @Get(':phone_number/pdf')
    async getMedicalRecordPdf(@Param('phone_number') phone_number: string, @Res() res: Response) {
        return this.mediserv.generatePdfForPatient(phone_number.trim(), res);
    }
}