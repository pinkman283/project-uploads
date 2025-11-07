import { IsNotEmpty } from 'class-validator';

export class check2 {
    @IsNotEmpty({ message: 'Please enter Doctor ID!' })
    doctorId: string;

    @IsNotEmpty({ message: 'Please enter valid Patient Phone!' })
    phone_number: string;
}
