'use client';

import React, { useState, useEffect } from 'react';
import { useRouter } from 'next/navigation';


const MedicalRecordPage = () => {
  const [medicalRecords, setMedicalRecords] = useState<any[]>([]); 
  const [loading, setLoading] = useState<boolean>(true); 
  const [error, setError] = useState<string>('');
  const [phoneNumber, setPhoneNumber] = useState<string | null>(null); 
  const router = useRouter();
    const [loadingPage, setLoadingPage] = useState(false);

  useEffect(() => {
    if (typeof window !== 'undefined') {
      const phone = localStorage.getItem('phone'); 
      setPhoneNumber(phone); 

      if (phone) {
        fetchMedicalRecords(phone);
      } else {
        setError('Phone number not found in localStorage.');
        setLoading(false);
      }
    }
  }, []);

  const fetchMedicalRecords = async (phone: string) => {
    const token = localStorage.getItem('token'); 

    try {
      const response = await fetch(`http://localhost:4000/medical-record/${phone}`, {
        method: 'GET',
        headers: {
          'Authorization': `Bearer ${token}`, 
        },
      });

      const data = await response.json();

      if (response.ok) {
        setMedicalRecords(data);
      } else {
        setError(data.message || 'Error fetching medical records');
      }
    } catch (err) {
      console.error('Error:', err);
      setError('Failed to fetch medical records');
    } finally {
      setLoading(false);
    }
  };

  const downloadMedicalRecordPdf = async () => {
    const token = localStorage.getItem('token'); 

    try {
      const response = await fetch(`http://localhost:4000/medical-record/${phoneNumber}/pdf`, {
        method: 'GET',
        headers: {
          'Authorization': `Bearer ${token}`, 
        },
      });

      if (response.ok) {
        const blob = await response.blob();
        const url = window.URL.createObjectURL(blob);
        const a = document.createElement('a');
        a.href = url;
        a.download = 'medical_record.pdf';
        a.click();
      } else {
        setError('Error downloading the PDF');
      }
    } catch (err) {
      console.error('Error:', err);
      setError('Failed to download medical record PDF');
    }
  };

  if (loading) {
    return (
      <div className="skeleton h-32 w-full"></div> 
    );
  }

  if (error) {
    return <p className="text-red-500">{error}</p>;
  }

  const handleNavigation = (href: string) => {
    setLoadingPage(true);
    setTimeout(() => {
      router.push (href);  
    }, 1000); 
  };

  return (
    <div className="min-h-screen bg-gray-100 flex justify-center items-center py-10 px-5">
      <div className="w-full max-w-lg bg-white rounded-lg shadow-md p-6 space-y-6">
        <h2 className="text-2xl font-semibold text-center text-blue-600">Medical Records</h2>

        {medicalRecords.length > 0 ? (
          <div className="space-y-4">
            {medicalRecords.map((record, index) => (
              <div key={index} className="border-b py-4">
                <h3 className="text-lg font-semibold">Record #{index + 1}</h3>
                <p><strong>Diagnosis:</strong> {record.diagnosis}</p>
                <p><strong>Medications:</strong> {record.medications?.join(', ')}</p>
                <p><strong>Test Results:</strong> {record.testresults}</p>
                <p><strong>Prescription Refill Available:</strong> {record.prescriptionrefillavailable ? 'Yes' : 'No'}</p>
                <p><strong>Created At:</strong> {new Date(record.createdat).toLocaleString()}</p>
              </div>
            ))}
          </div>
        ) : (
          <p>No medical records available.</p>
        )}

        {/* Download PDF Button */}
        <div className="flex justify-center gap-4">
          <button
            onClick={downloadMedicalRecordPdf}
            className="w-40 bg-blue-600 text-white py-2 rounded-md hover:bg-blue-700 transition duration-300"
          >
            Download PDF
          </button>

           <button
            onClick={() => handleNavigation('/dashboard')}
            className="w-20 bg-white border rounded-lg py-1 px-3 text-center shadow hover:bg-gray-50 transition-all duration-300 ease-in-out transform hover:scale-70"
            >
            <p className="text-xs font-small">Back</p>
            </button>

        </div>
      </div>
    </div>
  );
};

export default MedicalRecordPage;
