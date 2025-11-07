'use client';

import React, { useState } from 'react';
import Link from 'next/link';
import {
  Home,
  Info,
  Camera,
  Phone,
  CalendarPlus,
  FileText,
  Star,
  Plus,
  X,
} from 'lucide-react';

const LandingPage = () => {
  const [popupSection, setPopupSection] = useState('');

  const renderPopupContent = () => {
    switch (popupSection) {
      case 'about':
        return (
          <>
            <h3 className="text-lg font-bold mb-2">About Our Hospital</h3>
            <p>Founded in 1990 with world-class facilities.</p>
            <p>500+ certified doctors</p>
            <p>24/7 emergency services</p>
          </>
        );
      case 'services':
        return (
          <>
            <h3 className="text-lg font-bold mb-2">Our Services</h3>
            <ul className="list-disc pl-5 space-y-1">
              <li>General Consultation</li>
              <li>Surgery</li>
              <li>Diagnostic Testing</li>
              <li>Emergency Care</li>
            </ul>
          </>
        );
      case 'contact':
        return (
          <>
            <h3 className="text-lg font-bold mb-2">Contact Us</h3>
            <p>Email: support@healthcare.com</p>
            <p>Phone: +880-1234-567890</p>
            <p>Location: Dhaka, Bangladesh</p>
          </>
        );
      default:
        return null;
    }
  };

  return (
    <div className="flex flex-col min-h-screen font-sans bg-gray-50 relative">
      {/* Main Layout */}
      <div className="flex flex-1">
        {/* Sidebar */}
        <aside className="bg-blue-500 w-52 p-4 flex flex-col items-center text-white">
          <div className="flex items-center gap-2 mb-10">
            <div className="bg-white rounded p-1">
              <Plus className="text-blue-500 w-4 h-4" />
            </div>
            <span className="text-lg font-bold">HealthCare</span>
          </div>

          <nav className="flex flex-col gap-6 text-sm w-full">
            <Link
              href="#"
              className="bg-white text-blue-500 py-2 px-4 rounded flex items-center gap-2 font-semibold hover:bg-blue-100"
              onClick={() => setPopupSection('')}
            >
              <Home className="w-4 h-4" />
              Home
            </Link>
            <button
              onClick={() => setPopupSection('about')}
              className="flex items-center gap-2 px-4 hover:text-blue-200"
            >
              <Info className="w-4 h-4" />
              About
            </button>
            <button
              onClick={() => setPopupSection('services')}
              className="flex items-center gap-2 px-4 hover:text-blue-200"
            >
              <Camera className="w-4 h-4" />
              Services
            </button>
            <button
              onClick={() => setPopupSection('contact')}
              className="flex items-center gap-2 px-4 hover:text-blue-200"
            >
              <Phone className="w-4 h-4" />
              Contact
            </button>
          </nav>
        </aside>

        {/* Main Content */}
        <main className="flex-1 p-8">
          {/* Top nav */}
          <div className="flex justify-between mb-8">
            <div className="flex gap-6 text-gray-700 font-medium">
              <Link href="#" onClick={() => setPopupSection('')}>Home</Link>
              <button onClick={() => setPopupSection('about')}>About</button>
              <button onClick={() => setPopupSection('services')}>Services</button>
              <button onClick={() => setPopupSection('contact')}>Contact</button>
            </div>
            <Link href="/login" >
            <button className="bg-blue-600 text-white px-4 py-1 rounded hover:bg-blue-700">
              Login
            </button>
            </Link>
          </div>

          {/* Hero Section */}
          <div className="flex items-center gap-12 flex-wrap">
            <div>
              <h1 className="text-4xl font-bold text-gray-800 leading-tight">
                Manage your <br /> Health, <br /> Anytime, Anywhere
              </h1>
              <p className="text-gray-600 mt-4">
                Book appointments, view medical records, and more.
              </p>
            </div>
            <img src="/abd.png" alt="Doctor and Patient" className="w-[300px] h-auto" />
          </div>

          {/* Action Cards */}
          <div className="mt-12 flex gap-6 flex-wrap">
            <Link href="/login">
              <div className="cursor-pointer bg-white shadow rounded p-6 text-center w-52 hover:shadow-md transition">
                <CalendarPlus className="text-blue-500 w-6 h-6 mb-3 mx-auto" />
                <p className="font-semibold">Book Appointment</p>
              </div>
            </Link>
            <Link href="/login">
              <div className="cursor-pointer bg-white shadow rounded p-6 text-center w-52 hover:shadow-md transition">
                <FileText className="text-blue-500 w-6 h-6 mb-3 mx-auto" />
                <p className="font-semibold">Access Medical Records</p>
              </div>
            </Link>
            <Link href="/login">
              <div className="cursor-pointer bg-white shadow rounded p-6 text-center w-52 hover:shadow-md transition">
                <Star className="text-yellow-400 w-6 h-6 mb-3 mx-auto" />
                <p className="font-semibold">Rate Your Experience</p>
              </div>
            </Link>
          </div>
        </main>
      </div>

      {/* Bottom Pop-up */}
      <div
        className={`fixed bottom-0 left-0 right-0 z-50 bg-white shadow-lg border-t rounded-t-2xl p-6 transition-transform duration-500 ${
          popupSection ? 'translate-y-0' : 'translate-y-full'
        }`}
      >
        <div className="flex justify-between items-center mb-4">
          <span className="text-gray-800 font-semibold capitalize">{popupSection} Info</span>
          <button
            className="text-gray-500 hover:text-red-500"
            onClick={() => setPopupSection('')}
          >
            <X className="w-5 h-5" />
          </button>
        </div>
        <div className="text-sm text-gray-700 space-y-1">{renderPopupContent()}</div>
      </div>
    </div>
  );
};

export default LandingPage;
