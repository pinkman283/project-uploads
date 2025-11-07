import { IsNotEmpty } from "class-validator";

export class check{
    @IsNotEmpty({message:'enter phone number'})
    phone_number:string
    @IsNotEmpty({message:'enter password'})
    password:string
}