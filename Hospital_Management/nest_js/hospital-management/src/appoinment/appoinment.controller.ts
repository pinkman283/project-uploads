import { Body, Controller, Get, Param, Post, UseGuards, ValidationPipe } from '@nestjs/common';
import { AppoinmentService } from './appoinment.service';
import { check } from 'src/patient/dto/check.dto';
import { check2 } from './dto/check2.dto';
import { AuthGuard } from '@nestjs/passport';
@Controller('appoinment')
export class AppoinmentController {
    constructor(private readonly appoinmentserv: AppoinmentService) {}

    //@UseGuards(AuthGuard('jwt'))
    @Post('book')
    book(@Body(new ValidationPipe()) body: check2) {
        return this.appoinmentserv.book(body);
    }

   // @UseGuards(AuthGuard('jwt'))
    @Post('cancel')
    cancel(@Body() body: { appointmentId: number }) {
        return this.appoinmentserv.cancel(body);
    }

    //@UseGuards(AuthGuard('jwt'))
    @Get('upcoming-appointment/:phone_number')
    async getUpcomingAppointment(@Param('phone_number') phone_number: string) {
    return this.appoinmentserv.getUpcomingAppointment(phone_number);
}
}
