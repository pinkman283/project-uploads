import { MESSAGES } from "@nestjs/core/constants";
import { isNotEmpty, IsNotEmpty } from "class-validator";

export class check{
    @IsNotEmpty({message:'please enter full name!'})
    full_name:string
    @IsNotEmpty({message:'please enter date of birth!'})
    date_of_birth:string
    @IsNotEmpty({message:'enter valid phone number!'})
    phone_number:string
    @IsNotEmpty({message:'enter valid email!'})
    email:string
    @IsNotEmpty({message:'provide the insurance number!'})
    insurance_number:string
    @IsNotEmpty({message:'enter the password field'})
    password:string
}