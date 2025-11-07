'use client';

import React, { useState, useEffect } from 'react';
import { useRouter } from 'next/navigation';

const AppointmentsPage = () => {
  const [doctors, setDoctors] = useState<any[]>([]); 
  const [searchQuery, setSearchQuery] = useState<string>(''); 
  const [category, setCategory] = useState<string>(''); 
  const [filteredDoctors, setFilteredDoctors] = useState<any[]>([]); 
  const [loading, setLoading] = useState<boolean>(false);  
  const [successMessage, setSuccessMessage] = useState<string>(''); 
  const [errorMessage, setErrorMessage] = useState<string>('');
  const router = useRouter();
  const [loadingPage, setLoadingPage] = useState(false);

  const categories = [
    'Cardiology', 'Neurology', 'Orthopedics', 'Pediatrics', 'Dentistry', 'Dermatology', 'Gynecology', 'General Medicine'
  ];  

  // Fetch all doctors from backend
  useEffect(() => {
    fetchDoctors();
  }, []);

  // Fetch all doctors
  const fetchDoctors = async () => {
    setLoading(true);
    try {
      const response = await fetch('http://localhost:4000/doctor/allDoctors', {
        headers: {
          'Authorization': `Bearer ${localStorage.getItem('token')}`, 
        },
      });

      const data = await response.json();
      if (response.ok) {
        setDoctors(data);  
        setFilteredDoctors(data); 
      } else {
        console.error('Failed to fetch doctors');
      }
    } catch (error) {
      console.error('Error fetching doctors:', error);
    } finally {
      setLoading(false);
    }
  };

  const handleSearch = async () => {
    if (searchQuery.trim() === '') {
      setFilteredDoctors(doctors); 
    } else {
      try {
        const response = await fetch(`http://localhost:4000/doctor/searchDoc/${searchQuery}`, {
          headers: {
            'Authorization': `Bearer ${localStorage.getItem('token')}`,
          },
        });

        const data = await response.json();
        if (response.ok) {
          setFilteredDoctors(data); 
        } else {
          setFilteredDoctors([]);  
        }
      } catch (error) {
        console.error('Error searching doctors by name:', error);
        setFilteredDoctors([]);  
      }
    }
  };

  const handleCategoryChange = async (e: React.ChangeEvent<HTMLSelectElement>) => {
    const selectedCategory = e.target.value;
    setCategory(selectedCategory);

    if (selectedCategory === '') {
      setFilteredDoctors(doctors);  
    } else {
      try {
        const response = await fetch(`http://localhost:4000/doctor/Specialization/${selectedCategory}`, {
          headers: {
            'Authorization': `Bearer ${localStorage.getItem('token')}`, 
          },
        });

        const data = await response.json();
        if (response.ok) {
          setFilteredDoctors(data);  
        } else {
          setFilteredDoctors([]);  
        }
      } catch (error) {
        console.error('Error searching doctors by specialization:', error);
        setFilteredDoctors([]);  
      }
    }
  };

  const handleBookAppointment = async (doctorId: string) => {
    const phone = localStorage.getItem('phone'); 

    if (!phone) {
      alert('User phone number is missing. Please log in again.');
      return;
    }

    const payload = {
      doctorId,
      phone_number: phone,
    };

    try {
      setLoading(true);
      const response = await fetch('http://localhost:4000/appoinment/book', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
          'Authorization': `Bearer ${localStorage.getItem('token')}`, 
        },
        body: JSON.stringify(payload),
      });

      const data = await response.json();
      if (response.ok) {
        setSuccessMessage(`Appointment booked successfully with Dr. ${data.doctor_name}!`);
        setErrorMessage(''); 
        setTimeout(() => {
          setSuccessMessage('');  
        }, 10000);
      } else {
        setSuccessMessage(''); 
        setErrorMessage(data.message || 'Failed to book the appointment.');
      }
    } catch (error) {
      console.error('Error booking appointment:', error);
      setSuccessMessage(''); 
      setErrorMessage('Error booking appointment.');
    } finally {
      setLoading(false);
    }
  };

  const handleViewHistory = () => {
    router.push('/history');
  };

  const handleNavigation = (href: string) => {
    setLoadingPage(true);
    setTimeout(() => {
      router.push(href);  
    }, 1000); 
  };

  return (
    <div className="min-h-screen bg-gray-100 flex justify-center items-center p-6">
      <div className="w-full max-w-3xl bg-white rounded-lg shadow-md p-6">
        <h1 className="text-2xl font-semibold text-center mb-6">Appointments</h1>

        <div className="flex gap-4 mb-6">
          <div className="w-1/2">
            <input
              type="text"
              placeholder="Search Doctor by Name"
              value={searchQuery}
              onChange={(e) => setSearchQuery(e.target.value)}
              className="input input-bordered w-full"
            />
          </div>
          <button
            onClick={handleSearch}
            className="btn btn-primary text-white bg-blue-600 hover:bg-blue-700 px-6 py-2 rounded-md transition duration-300"
          >
            Search
          </button>
          <div className="w-1/2">
            <select
              className="input input-bordered w-full"
              value={category}
              onChange={handleCategoryChange}
            >
              <option value="">Select Specialization</option>
              {categories.map((cat, index) => (
                <option key={index} value={cat}>{cat}</option>
              ))}
            </select>
          </div>
        </div>

        {/* Doctors list */}
        {loading ? (
          <div className="flex justify-center">
            <div className="skeleton h-32 w-full"></div> 
          </div>
        ) : (
          <div>
            {filteredDoctors.length === 0 ? (
              <p className="text-center text-gray-500">No doctors found</p>
            ) : (
              <div>
                {filteredDoctors.map((doctor) => (
                  <div key={doctor.id} className="flex justify-between items-center mb-4 p-4 border-b">
                    <div>
                      <h3 className="text-lg font-semibold">{doctor.name}</h3>
                      <p className="text-gray-500">{doctor.specialization}</p>
                      <p className="text-gray-500">{`Available from: ${doctor.available_from} to ${doctor.available_to}`}</p>
                    </div>
                    <button
                      onClick={() => handleBookAppointment(doctor.id)}
                      className="btn btn-primary text-white bg-blue-600 hover:bg-blue-700 px-4 py-2 rounded-md"
                    >
                      Book Appointment
                    </button>
                  </div>
                ))}
              </div>
            )}
          </div>
        )}

        {successMessage && <p className="text-green-500">{successMessage}</p>}
        {errorMessage && <p className="text-red-500">{errorMessage}</p>}

        <div className="flex justify-center gap-4 mt-6">
          <button
            onClick={handleViewHistory}
            className="btn btn-secondary text-white bg-gray-600 hover:bg-gray-700 px-4 py-2 rounded-md transition duration-300"
          >
            upcoming appointments
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

export default AppointmentsPage;
