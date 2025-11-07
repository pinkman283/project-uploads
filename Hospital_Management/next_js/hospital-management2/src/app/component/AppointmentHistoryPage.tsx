'use client';

import React, { useState, useEffect } from 'react';
import { useRouter } from 'next/navigation';

const AppointmentHistoryPage = () => {
  const [appointments, setAppointments] = useState<any[]>([]);  
  const [loading, setLoading] = useState<boolean>(false); 
  const [errorMessage, setErrorMessage] = useState<string>(''); 
  const router = useRouter();

  useEffect(() => {
    fetchAppointments();
  }, []);

  const fetchAppointments = async () => {
    setLoading(true);
    const phone = localStorage.getItem('phone'); 

    if (!phone) {
      setErrorMessage('User phone number is missing. Please log in again.');
      setLoading(false);
      return;
    }

    try {
      const response = await fetch(`http://localhost:4000/appoinment/upcoming-appointment/${phone}`, {
        headers: {
          'Authorization': `Bearer ${localStorage.getItem('token')}`, // Send token for authentication
        },
      });

      // Check if the response is successful
      if (!response.ok) {
        throw new Error('Failed to fetch appointments from the server.');
      }

      const data = await response.json();

      // Log the full response to see its structure
      console.log("Response Data:", data);

      // Adjusting based on response structure
      if (data.appointments && Array.isArray(data.appointments)) {
        const filteredAppointments = data.appointments.map((appointment: any) => ({
          appointment_time: appointment.appointment_time,
          doctorId: appointment.doctorId, // Only doctor id
          patientPhone: appointment.phone_number, // Only patient phone number
        }));
        setAppointments(filteredAppointments);
      } else {
        setErrorMessage('The response is not in the expected format.');
      }
    } catch (error) {
      console.error('Error fetching appointments:', error);
      setErrorMessage('There was an error fetching your appointments. Please try again later.');
    } finally {
      setLoading(false);
    }
  };

  const handleBackToDashboard = () => {
    router.push('/dashboard');
  };

  return (
    <div className="min-h-screen bg-gray-100 flex justify-center items-center p-6">
      <div className="w-full max-w-3xl bg-white rounded-lg shadow-md p-6">
        <h1 className="text-2xl font-semibold text-center mb-6">Appointments</h1>

        {/* Loading State */}
        {loading && <div className="flex justify-center"><div className="skeleton h-32 w-full"></div></div>}

        {/* Error Message */}
        {errorMessage && <p className="text-red-500 text-center">{errorMessage}</p>}

        {/* Appointments List */}
        {!loading && !errorMessage && (
          <div>
            {appointments.length === 0 ? (
              <p className="text-center text-gray-500">No appointments found.</p>
            ) : (
              <div>
                <h3 className="text-lg font-semibold mb-4">Upcoming Appointments</h3>
                {appointments
                  .filter((appointment) => new Date(appointment.appointment_time) > new Date()) // Upcoming appointments
                  .map((appointment, index) => (
                    <div key={index} className="flex justify-between items-center mb-4 p-4 border-b">
                      <div>
                        <p className="text-gray-500">{`Appointment Time: ${new Date(appointment.appointment_time).toLocaleString()}`}</p>
                        <p className="text-gray-500">{`Doctor ID: ${appointment.doctorId || 'Doctor not available'}`}</p>
                        <p className="text-gray-500">{`Patient Phone: ${appointment.patientPhone || 'Phone number not available'}`}</p>
                      </div>
                    </div>
                  ))}
              </div>
            )}
          </div>
        )}

        {/* Back Button */}
        <div className="flex justify-center gap-4 mt-6">
          <button
            onClick={handleBackToDashboard}
            className="btn btn-secondary text-white bg-gray-600 hover:bg-gray-700 px-4 py-2 rounded-md transition duration-300"
          >
            Back to Dashboard
          </button>
        </div>
      </div>
    </div>
  );
};

export default AppointmentHistoryPage;
