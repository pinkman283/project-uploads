import { Controller, Get, Query, BadRequestException } from '@nestjs/common';
import { ProfileService } from './profile.service';

@Controller('profile')
export class ProfileController {
  constructor(private readonly profileService: ProfileService) {}

  @Get('patient-info')
  async info(@Query('phone_number') phone_number: string) {
    if (!phone_number) {
      throw new BadRequestException('Phone number is required');
    }
    return this.profileService.getPatientByPhoneNumber(phone_number);
  }
}
