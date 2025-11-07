import { Controller, Get, Param, Post, Query, UseGuards } from '@nestjs/common';
import { DoctorService } from './doctor.service';
import { AuthGuard } from '@nestjs/passport';

@Controller('doctor')
export class DoctorController {
  constructor(private readonly doctorserv: DoctorService) {}

 // @UseGuards(AuthGuard('jwt'))
  @Get('allDoctors')
  findAll() {
    return this.doctorserv.findAll();
  }

  //@UseGuards(AuthGuard('jwt'))
  @Get('specialization/:type')
  searchSpecialization(@Param('type') type: string) {
    return this.doctorserv.searchSpecialization(type);
  }

  //@UseGuards(AuthGuard('jwt'))
  @Get('searchDoc/:query')
  searchDoctor(@Param('query') query: string) {
    return this.doctorserv.searchDoctors(query);
  }
}
