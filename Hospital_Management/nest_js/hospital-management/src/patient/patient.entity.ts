import { Column, Entity, PrimaryGeneratedColumn } from "typeorm";

@Entity()
export class Patient
{
    @PrimaryGeneratedColumn()
    id:number
    @Column()
    full_name:string
    @Column()
    date_of_birth:string
    @Column({length:11})
    phone_number:string
    @Column()
    email:string
    @Column()
    insurance_number:string
    @Column()
    password:string
}