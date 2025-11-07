'use client';

import React, { useState } from 'react';
import { useRouter } from 'next/navigation';
import Registration from '../component/Registration';

const Page = () => {
  const router = useRouter();
  const [loading, setLoading] = useState(false);
  const [errorMessage, setErrorMessage] = useState('');
  const [successMessage, setSuccessMessage] = useState('');

  // Function to send OTP
  const onSendOtp = async (formData: any): Promise<boolean> => {
    setLoading(true);
    setErrorMessage('');
    setSuccessMessage('');

    try {
      const res = await fetch('http://localhost:4000/patient-reg/send-otp', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
          full_name: formData.fullName,
          date_of_birth: formData.dob,
          phone_number: formData.phone,
          email: formData.email,
          insurance_number: formData.insurance,
          password: formData.password,
        }),
      });

      const result = await res.json();
      console.log('[Frontend] send-otp response:', result);

      // If there's an error message from the backend, display it and stop transitioning
      if (!res.ok) {
        setErrorMessage(result.message || 'Failed to send OTP');
        setLoading(false);
        return false;  // Stop the flow and don't go to OTP page
      }

      // If successful, proceed to OTP page
      setSuccessMessage(`OTP sent to ${formData.email}`);
      setLoading(false);
      return true;  // Proceed to OTP page
    } catch (err) {
      console.error('[Frontend] Error sending OTP:', err);
      setErrorMessage('Error sending OTP. Please try again.');
      setLoading(false);
      return false;
    }
  };

  // Function to verify OTP
  const onVerifyOtp = async (otp: string, formData: any) => {
    setLoading(true);
    setErrorMessage('');
    setSuccessMessage('');

    try {
      const res = await fetch('http://localhost:4000/patient-reg/verify-otp', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
          email: formData.email,
          otp,
          full_name: formData.fullName,
          date_of_birth: formData.dob,
          phone_number: formData.phone,
          insurance_number: formData.insurance,
          password: formData.password,
        }),
      });

      const result = await res.json();
      console.log('[Frontend] verify-otp response:', result);

      // Handle the response
      if (res.ok) {
        setSuccessMessage('Registration successful!');
        router.push('/login');  // Navigate to login page
      } else {
        setErrorMessage(result.message || 'OTP verification failed');
      }
    } catch (err) {
      console.error('[Frontend] Error verifying OTP:', err);
      setErrorMessage('Error verifying OTP. Please try again.');
    }

    setLoading(false);
  };

  return (
    <Registration
      onSendOtp={onSendOtp}
      onVerifyOtp={onVerifyOtp}
      errorMessage={errorMessage}
      successMessage={successMessage}
      loading={loading}
      setErrorMessage={setErrorMessage}
      setSuccessMessage={setSuccessMessage}
    />
  );
};

export default Page;
