'use client';

import React, { useState, useEffect } from 'react';
import Link from 'next/link'; 

const ProfilePage = () => {
  const [userDetails, setUserDetails] = useState<any>(null);  
  const [loading, setLoading] = useState(true);              
  const [error, setError] = useState<string>('');             

  useEffect(() => {
    const phone = localStorage.getItem('phone'); 
    if (phone) {
      fetchUserProfile(phone); 
    } else {
      setError('Phone number not found in localStorage');
      setLoading(false);
    }
  }, []);

  const fetchUserProfile = async (phone: string) => {
    try {
      const response = await fetch(`http://localhost:4000/profile/patient-info?phone_number=${phone}`);
      const data = await response.json();

      console.log('Response from backend:', data); 

      if (response.ok) {
        setUserDetails(data);  
      } else {
        setError('Failed to fetch user profile');
      }
    } catch (err) {
      console.error('Error fetching profile:', err);
      setError('Error fetching profile');
    } finally {
      setLoading(false);  
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

  return (
    <div className="min-h-screen bg-gray-100 flex items-center justify-center py-10 px-5">
      <div className="bg-white rounded-lg shadow-lg w-full max-w-lg p-6 space-y-6">
        <h1 className="text-2xl font-semibold text-center text-blue-600">User Profile</h1>

        {userDetails ? (
          <div className="space-y-4">
            <div className="flex justify-between items-center">
              <p className="text-lg font-medium text-gray-700">Name:</p>
              <p className="text-lg text-gray-600">{userDetails.full_name}</p>
            </div>

            <div className="flex justify-between items-center">
              <p className="text-lg font-medium text-gray-700">Phone:</p>
              <p className="text-lg text-gray-600">{userDetails.phone_number}</p>
            </div>

            <div className="flex justify-between items-center">
              <p className="text-lg font-medium text-gray-700">Email:</p>
              <p className="text-lg text-gray-600">{userDetails.email}</p>
            </div>

            <div className="flex justify-between items-center">
              <p className="text-lg font-medium text-gray-700">Insurance Number:</p>
              <p className="text-lg text-gray-600">{userDetails.insurance_number}</p>
            </div>

            <div className="flex justify-between items-center">
              <p className="text-lg font-medium text-gray-700">Password:</p>
              <p className="text-lg text-gray-600">{userDetails.password}</p>
            </div>
          </div>
        ) : (
          <p className="text-red-500">No user details available</p>
        )}
        
        <div className="flex justify-center gap-4">
          <button className="btn btn-primary text-white bg-blue-600 hover:bg-blue-700 px-4 py-2 rounded-md transition duration-300">
            Edit Profile
          </button>
          {/* Use Next.js Link component for routing */}
          <Link href="/dashboard">
            <button className="btn btn-secondary text-white bg-gray-600 hover:bg-gray-700 px-4 py-2 rounded-md transition duration-300">
              Back 
            </button>
          </Link>
        </div>
      </div>
    </div>
  );
};

export default ProfilePage;
