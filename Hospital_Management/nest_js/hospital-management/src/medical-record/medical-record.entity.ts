import { Entity, PrimaryGeneratedColumn, Column } from 'typeorm';

@Entity()
export class MedicalRecord {
  @PrimaryGeneratedColumn()
  id: number;

  @Column()
  phone_number: string;

  @Column()
  diagnosis: string;

  @Column('simple-array')
  medications: string[];

  @Column('text')
  testresults: string;

  @Column()
  prescriptionrefillavailable: boolean;

  @Column({ type: 'timestamp', default: () => 'CURRENT_TIMESTAMP' })
  createdat: Date;
}
