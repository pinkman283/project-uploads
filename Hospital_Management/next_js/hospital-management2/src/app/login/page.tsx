'use client';
import React, { useState } from 'react';
import Fieldset from '../component/Fieldset';
import { useRouter } from 'next/navigation';

const page = () => {
  const [phone, setPhone] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState('');
  const router = useRouter();

  const handleLogin = async (e: React.FormEvent) => {
    e.preventDefault();

    try {
      const response = await fetch('http://localhost:4000/patient/login', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({
          phone_number: phone.trim(),
          password: password.trim(),
        }),
      });

      const text = await response.text();
      const data = text ? JSON.parse(text) : {};

      console.log('Login API response:', data);

      if (!response.ok) {
        setError(data.message || 'Login failed');
        return;
      }

      if (data.token) {
      localStorage.setItem('token', data.token);
      localStorage.setItem('phone', data.user.phone_number);
      localStorage.setItem('username', data.user.name);
      
      const token = localStorage.getItem('token');
      const phone = localStorage.getItem('phone');
      const username = localStorage.getItem('username');

      if (token && phone && username) {
        router.push('/dashboard');
      } else {
        setError('Failed to save user data. Please try again.');
      }
    } else {
      setError('Invalid phone number or password.');
}
    } catch (err) {
      console.error(err);
      setError('Invalid phone number or password.');
    }
  };

  return (
    <div className="min-h-screen flex justify-center items-center bg-base-100">
      <Fieldset
        phone={phone}
        password={password}
        error={error}
        setPhone={setPhone}
        setPassword={setPassword}
        handleLogin={handleLogin}
      />
    </div>
  );
};

export default page;
