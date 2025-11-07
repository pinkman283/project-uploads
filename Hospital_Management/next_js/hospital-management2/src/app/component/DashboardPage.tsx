'use client';

import React, { useState, useEffect } from 'react';
import Image from 'next/image';
import Link from 'next/link';
import { useRouter } from 'next/navigation';

const DashboardPage = () => {
  const [showAlert, setShowAlert] = useState(false);  
  const [userName, setUserName] = useState<string | null>(''); 
  const [loading, setLoading] = useState(false);
  const [loadingPage, setLoadingPage] = useState(false); 
  const [upcomingAppointment, setUpcomingAppointment] = useState<any>(null);  
  const router = useRouter();

  useEffect(() => {
    const loggedInUser = localStorage.getItem('username'); 

    if (loggedInUser) {
      setUserName(loggedInUser);
    } else {
      setUserName('Guest');
    }

    const phone = localStorage.getItem('phone');
    if (phone) {
      fetchUpcomingAppointment(phone);
    }
  }, []);

  const fetchUpcomingAppointment = async (phone: string) => {
    try {
      const response = await fetch(`http://localhost:4000/appoinment/get-upcoming-appointment/${phone}`, {
        headers: {
          'Authorization': `Bearer ${localStorage.getItem('token')}`,
        },
      });
      const data = await response.json();

      if (response.ok) {
        setUpcomingAppointment(data);
      } else {
        setUpcomingAppointment(null); 
      }
    } catch (error) {
      console.error('Error fetching upcoming appointment:', error);
      setUpcomingAppointment(null);
    }
  };

  const handleBooking = (e: React.FormEvent) => {
    e.preventDefault();
    setShowAlert(true); 
    setTimeout(() => setShowAlert(false), 3000); 
  };

  const handleLogout = () => {
    setLoading(true);
    localStorage.removeItem('username');
    localStorage.removeItem('token');
    localStorage.removeItem('phone');
    setTimeout(() => {
      router.push('/landingpage');
    }, 1500); 
  };

  const handleNavigation = (href: string) => {
    setLoadingPage(true);
    setTimeout(() => {
      router.push(href);  
    }, 1000); 
  };

  return (
    <div className="min-h-screen font-sans">
      <div className="flex bg-gray-50">
        {/* Sidebar */}
        <aside className="w-64 bg-white shadow-md flex flex-col justify-between">
          <div>
            <div className="p-6 flex items-center gap-2">
              <Image src="/logo.png" alt="Logo" width={30} height={30} />
              <h2 className="text-xl font-bold text-[#266AA9]">HealthCare</h2>
            </div>
            <nav className="flex flex-col gap-2 px-4">
              {[{ label: 'Dashboard', href: '/dashboard' }, { label: 'Appointments', href: '/appointment' }, { label: 'Billing', href: '/billing' }, { label: 'Message', href: '/message' }].map(({ label, href }) => (
                <button
                  key={label}
                  onClick={() => handleNavigation(href)} 
                  className="px-3 py-2 rounded-md hover:bg-blue-100 text-sm text-gray-700 transition-all duration-300 ease-in-out transform hover:scale-105"
                >
                  {loadingPage ? (
                    <div className="skeleton h-32 w-full"></div> 
                  ) : (
                    label
                  )}
                </button>
              ))}
            </nav>
          </div>
        </aside>

        {/* Main Content */}
        <main className="flex-1 p-8">
          {/* Navbar */}
          <div className="navbar bg-base-100 shadow-sm px-6 mb-6 flex justify-between items-center">
            {loading ? (
              <div className="flex w-52 flex-col gap-4">
                <div className="skeleton h-32 w-full"></div>
                <div className="skeleton h-4 w-28"></div>
                <div className="skeleton h-4 w-full"></div>
                <div className="skeleton h-4 w-full"></div>
              </div>
            ) : (
              <h1 className="text-2xl font-bold">Welcome, {userName || 'Guest'}</h1>
            )}
            <div className="dropdown dropdown-end">
              <div tabIndex={0} role="button" className="btn btn-ghost btn-circle avatar">
                <div className="w-10 rounded-full">
                  <img alt="Profile Icon" src="https://img.daisyui.com/images/stock/photo-1534528741775-53994a69daeb.webp" />
                </div>
              </div>
              <ul tabIndex={0} className="menu menu-sm dropdown-content bg-base-100 rounded-box z-10 mt-3 w-52 p-2 shadow">
                <li>
                  <Link href="/profile" className="justify-between text-blue-600 hover:text-blue-800">
                    Profile
                  </Link>
                </li>
                <li>
                  <button
                    onClick={handleLogout}
                    className="text-sm text-white bg-gray-600 hover:bg-gray-700 px-4 py-2 rounded-md transition duration-300 ease-in-out transform hover:scale-105"
                  >
                    {loading ? (
                      <div className="skeleton h-32 w-full"></div>
                    ) : (
                      'Logout'
                    )}
                  </button>
                </li>
              </ul>
            </div>
          </div>

          {/* Main Dashboard Content */}
          <div className="flex justify-between items-start gap-8 flex-wrap">
            {/* Upcoming Appointment Section */}
            <div className="flex-1 min-w-[300px]">
              {/* Upcoming Appointment */}
              <div className="bg-white border rounded-lg p-4 shadow-sm mb-6">
                <h2 className="text-lg font-semibold text-white bg-[#266AA9] px-4 py-2 rounded-t-md">
                  Upcoming Appointments
                </h2>
                <div className="mt-3">
                  {showAlert && (
                    <div role="alert" className="alert alert-success mb-4">
                      <svg xmlns="http://www.w3.org/2000/svg" className="h-6 w-6 shrink-0 stroke-current" fill="none" viewBox="0 0 24 24">
                        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M9 12l2 2 4-4m6 2a9 9 0 11-18 0 9 9 0 0118 0z" />
                      </svg>
                      <span>Your appointment has been successfully booked!</span>
                    </div>
                  )}

                  {upcomingAppointment ? (
                    <>
                      <p className="text-sm text-gray-700">📅 {upcomingAppointment.appointment_time}</p>
                      <p className="text-sm text-gray-700">🩺 {upcomingAppointment.department}</p>
                      <p className="text-sm text-gray-700">👨‍⚕️ {upcomingAppointment.doctor_name}</p>
                    </>
                  ) : (
                    <p className="text-sm text-gray-700">No upcoming appointments</p>
                  )}
                </div>
              </div>

              {/* Actions */}
              <div className="flex gap-4 mb-6">
                {loadingPage ? (
                  <div className="skeleton h-32 w-full"></div>  
                ) : (
                  <>
                    <button
                      onClick={() => handleNavigation('/medicalRecords')}
                      className="flex-1 bg-white border rounded-lg p-4 text-center shadow hover:bg-gray-100 transition-all duration-300 ease-in-out transform hover:scale-105"
                    >
                      <p className="font-medium">Medical Records</p>
                    </button>
                    <button
                      onClick={() => handleNavigation('/test-results')}
                      className="flex-1 bg-white border rounded-lg p-4 text-center shadow hover:bg-gray-100 transition-all duration-300 ease-in-out transform hover:scale-105"
                    >
                      <p className="font-medium">Test Results</p>
                    </button>
                    <button
                      onClick={() => handleNavigation('/feedback')}
                      className="flex-1 bg-white border rounded-lg p-4 text-center shadow hover:bg-gray-100 transition-all duration-300 ease-in-out transform hover:scale-105"
                    >
                      <p className="font-medium">Give Feedback</p>
                    </button>
                  </>
                )}
              </div>
            </div>

            {/* Booking Section */}
            <div className="bg-white p-6 rounded-lg shadow-md min-w-[320px]">
              <div className="flex justify-center mb-4">
                <Image src="/doctor.png" alt="Doctor" width={120} height={120} />
              </div>
              <h2 className="text-lg font-semibold mb-4 text-center">Book Appointment</h2>

              <form onSubmit={handleBooking} className="space-y-3">
                <input type="date" className="input input-bordered w-full" required />
                <input type="text" placeholder="Doctor" className="input input-bordered w-full" required />
                <input type="text" placeholder="Department" className="input input-bordered w-full" required />
                <input type="time" className="input input-bordered w-full" required />
                <button type="submit" className="w-full bg-[#266AA9] hover:bg-[#1b4e7d] text-white py-2 rounded mt-2">
                  Book Now
                </button>
              </form>
            </div>
          </div>
        </main>
      </div>
    </div>
  );
};

export default DashboardPage;
