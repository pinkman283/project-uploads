import { Entity, PrimaryGeneratedColumn, Column, ManyToOne } from 'typeorm';
import { Patient } from '../patient/patient.entity';
import { Doctor } from './doctor.entity';

@Entity()
export class Appointment {
    @PrimaryGeneratedColumn()
    id: number;

    @ManyToOne(() => Doctor)
    doctor: Doctor;

    @ManyToOne(() => Patient)
    patient: Patient;

    @Column('timestamp') 
    appointment_time: Date;

    @Column({ default: 'Booked' })
    status: string; 

    
}
