import { Injectable } from '@nestjs/common';
import { MedicalRecord } from './medical-record.entity';
import { Repository } from 'typeorm';
import { InjectRepository } from '@nestjs/typeorm';
import { Patient } from 'src/patient/patient.entity';
import * as PDFDocument from 'pdfkit'; 
import { Response } from 'express';

@Injectable()
export class MedicalRecordService {
  constructor(
    @InjectRepository(MedicalRecord)
    private medicalrepo: Repository<MedicalRecord>,
    @InjectRepository(Patient)
    private patientrepo: Repository<Patient>
  ) {}

  private keepEmpty(value: any): string {
    if (value === null || value === undefined) return '';
    if (typeof value === 'string') return value;
    return String(value);
  }

  async getPatient(phone_number: string) {
    const patient = await this.patientrepo.findOne({ where: { phone_number } });

    if (!patient) {
      return { message: 'Invalid patient phone number', status: 404 };
    }

    const records = await this.medicalrepo.find({ where: { phone_number } });

    if (!records.length) {
      return { message: 'No medical report found', status: 404 };
    }

    return records;
  }

  async generatePdfForPatient(phone_number: string, res: Response) {
    try {
      const patient = await this.patientrepo.findOne({ where: { phone_number } });

      if (!patient) {
        return res.status(404).json({ message: 'Invalid patient phone number' });
      }

      const records = await this.medicalrepo.find({ where: { phone_number } });

      if (!records.length) {
        return res.status(404).json({ message: 'No medical report found' });
      }

      const doc = new PDFDocument();
      res.set('Content-Type', 'application/pdf');
      res.setHeader('Content-Disposition', 'inline; filename=medical_record.pdf');
      doc.pipe(res);

      doc.fontSize(18).text(`Medical Records for: ${phone_number}`, { underline: true });
      doc.moveDown();

      records.forEach((record, i) => {
        doc.fontSize(14).text(`Record #${i + 1}`);

        doc.text(`Diagnosis: ${this.keepEmpty(record.diagnosis)}`);

        const meds = Array.isArray(record.medications)
          ? record.medications.join(', ')
          : '';
        doc.text(`Medications: ${meds}`);

        doc.text(`Test Results: ${this.keepEmpty(record.testresults)}`);

        const refill = record.prescriptionrefillavailable ? 'Yes' : 'No';
        doc.text(`Prescription Refill Available: ${refill}`);

        const createdAt = record.createdat
          ? new Date(record.createdat).toLocaleString()
          : '';
        doc.text(`Created At: ${createdAt}`);
        doc.moveDown();
      });

      doc.end();
    } catch (error) {
      console.error('PDF generation error:', error);
      return res.status(500).json({ message: 'Internal Server Error while generating PDF' });
    }
  }
}
