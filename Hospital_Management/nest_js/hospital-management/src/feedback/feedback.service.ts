import { Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Feedback } from 'src/patient/feedback.entity';
import { Patient } from 'src/patient/patient.entity';
import { Repository } from 'typeorm';

@Injectable()
export class FeedbackService {
    constructor(@InjectRepository(Feedback) private myRepo: Repository<Feedback>,
                 @InjectRepository(Patient) private myRepo2: Repository<Patient> 
    ){}
   

    async submit(ab)
    {
        const result=await this.myRepo2.findOne({where:[{phone_number:ab.phone_number}]})
        if(result)
        {
        this.myRepo.save(ab);
        return "feedback submitted successfully";
        }
        else 
        {
            return "patient could not found!";
        }
    }
}
