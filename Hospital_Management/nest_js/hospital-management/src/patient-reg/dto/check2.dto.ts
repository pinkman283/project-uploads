import { MESSAGES } from "@nestjs/core/constants";
import { isNotEmpty, IsNotEmpty } from "class-validator";

export class check{
    @IsNotEmpty({message:'please enter the otp!'})
    otp:string
    
}