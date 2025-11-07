import { Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Appointment } from 'src/patient/appoinment.entity';
import { Doctor } from 'src/patient/doctor.entity';
import { Patient } from 'src/patient/patient.entity';
import { Repository } from 'typeorm';
import * as moment from 'moment';

@Injectable()
export class AppoinmentService {
  constructor(
    @InjectRepository(Appointment) private myRepo: Repository<Appointment>,
    @InjectRepository(Patient) private patientrepo: Repository<Patient>,
    @InjectRepository(Doctor) private doctorrepo: Repository<Doctor>,
  ) {}

  async book(body) {
    const doctor = await this.doctorrepo.findOne({
      where: { id: body.doctorId },
    });

    const patient = await this.patientrepo.findOne({
      where: { phone_number: body.phone_number },
    });

    if (!doctor || !patient) {
      return { status: 'error', message: 'Invalid doctor ID or patient phone number' };
    }

    const today = moment().format('YYYY-MM-DD');
    const from = moment(`${today} ${doctor.available_from}`, 'YYYY-MM-DD HH:mm');
    const to = moment(`${today} ${doctor.available_to}`, 'YYYY-MM-DD HH:mm');

    const doctorAppointments = await this.myRepo
      .createQueryBuilder('appointment')
      .leftJoinAndSelect('appointment.doctor', 'doctor')  
      .leftJoinAndSelect('appointment.patient', 'patient') 
      .where('appointment.doctorId = :doctorId', { doctorId: doctor.id })
      .andWhere('appointment.appointment_time BETWEEN :from AND :to', {
        from: from.toDate(),
        to: to.toDate(),
      })
      .orderBy('appointment.appointment_time', 'ASC')
      .getMany();

    const patientAppointments = await this.myRepo
      .createQueryBuilder('appointment')
      .leftJoinAndSelect('appointment.doctor', 'doctor') 
      .leftJoinAndSelect('appointment.patient', 'patient')  
      .where('appointment.patientId = :patientId', { patientId: patient.id })
      .andWhere('appointment.appointment_time BETWEEN :from AND :to', {
        from: from.toDate(),
        to: to.toDate(),
      })
      .orderBy('appointment.appointment_time', 'ASC')
      .getMany();

    console.log("Doctor appointments: ", doctorAppointments);
    console.log("Patient appointments: ", patientAppointments);

    const hasDoctorAppointment = patientAppointments.some(
      (app) => app.doctor?.id === doctor.id, 
    );
    if (hasDoctorAppointment) {
      return { status: 'error', message: 'You already have an appointment with this doctor today' };
    }

    const busyTimes = new Set<string>();

    doctorAppointments.forEach((app) => {
      busyTimes.add(moment(app.appointment_time).format('HH:mm'));
    });

    patientAppointments.forEach((app) => {
      busyTimes.add(moment(app.appointment_time).format('HH:mm'));
    });

    let nextTime = from.clone();
    while (nextTime.isBefore(to)) {
      const timeStr = nextTime.format('HH:mm');
      if (!busyTimes.has(timeStr)) {
        const appointment = this.myRepo.create({
          doctor,
          patient,
          appointment_time: nextTime.format('YYYY-MM-DD HH:mm'),
        });

        await this.myRepo.save(appointment);
        return { status: 'success', message: 'Appointment booked successfully', doctor_name: doctor.name };
      }
      nextTime.add(15, 'minutes');
    }

    return { status: 'error', message: 'No available time slots for this doctor today' };
  }

  async cancel(body) {
    const appointment = await this.myRepo.findOneBy({ id: body.appointmentId });
    if (!appointment) {
      return 'Appointment not found!';
    }
    appointment.status = 'Cancelled';
    await this.myRepo.save(appointment);
    return 'Appointment cancelled successfully';
  }

  async getUpcomingAppointment(phone_number: string) {
    const patient = await this.patientrepo.findOne({
      where: { phone_number },
    });

    if (!patient) {
      return { message: 'Patient not found', status: 404 };
    }

    const upcomingAppointment = await this.myRepo
      .createQueryBuilder('appointment')
      .select([
        'appointment.appointment_time', 
        'appointment.doctorId',  
        'patient.phone_number',  
      ])
      .leftJoin('appointment.patient', 'patient')  
      .where('appointment.patientId = :patientId', { patientId: patient.id })
      .andWhere('appointment.appointment_time > NOW()')  
      .orderBy('appointment.appointment_time', 'ASC')
      .getMany();

    if (!upcomingAppointment || upcomingAppointment.length === 0) {
      return { message: 'No upcoming appointment found', status: 404 };
    }

    return upcomingAppointment;
  }
}
