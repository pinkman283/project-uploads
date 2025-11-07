import { Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Doctor } from 'src/patient/doctor.entity';
import { Repository, ILike } from 'typeorm';

@Injectable()
export class DoctorService {
  constructor(@InjectRepository(Doctor) private myRepo: Repository<Doctor>) {}

  async findAll() {
    return this.myRepo.find();
  }

  async searchSpecialization(type: string) {
    let result= await this.myRepo.find({ where: { specialization: ILike(`%${type}%`) } });
    if(result)
    {
      return result;
    }
    return "specialization type not found";
  }

  async searchDoctors(query: string) {
  let result = await this.myRepo.find({ where: { name: ILike(`%${query}%`) } })
  if (result) {
    return result;
  }
  return "doctor not found";
}
}
