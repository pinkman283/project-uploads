import { Body, Controller, Get, Post, UseGuards, ValidationPipe } from '@nestjs/common';
import { PatientService } from './patient.service';
import { check } from './dto/check.dto';
import { AuthGuard } from '@nestjs/passport';

@Controller('patient')
export class PatientController {
    constructor(private readonly patientServ: PatientService) {}

    //@UseGuards(AuthGuard('jwt'))
    @Post('login')
    login(@Body(new ValidationPipe()) ab:check)
    {
        return this.patientServ.login(ab);
    }
}
