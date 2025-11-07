'use client';

import React, { useState } from 'react';

type Props = {
  onSendOtp: (formData: any) => Promise<boolean>;
  onVerifyOtp: (otp: string, formData: any) => Promise<void>;
  errorMessage: string;
  successMessage: string;
  loading: boolean;
  setErrorMessage: React.Dispatch<React.SetStateAction<string>>;
  setSuccessMessage: React.Dispatch<React.SetStateAction<string>>;
};

const Registration = ({
  onSendOtp,
  onVerifyOtp,
  errorMessage,
  successMessage,
  loading,
  setErrorMessage,
  setSuccessMessage,
}: Props) => {
  const [isCodeStep, setIsCodeStep] = useState(false);
  const [codeInput, setCodeInput] = useState('');
  const [formData, setFormData] = useState({
    fullName: '',
    dob: '',
    phone: '',
    email: '',
    insurance: '',
    password: '',
  });

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleRegisterClick = async () => {
    if (!isCodeStep) {
      const allFilled = Object.values(formData).every(Boolean);
      if (!allFilled) {
        setErrorMessage('Please fill in all fields.');
        return;
      }

      const success = await onSendOtp(formData);
      if (success) {
        setIsCodeStep(true);
      }
    } else {
      if (!codeInput.trim()) {
        setErrorMessage('Please enter the OTP.');
        return;
      }
      await onVerifyOtp(codeInput, formData);
    }
  };

  const handleResend = async () => {
    await onSendOtp(formData);
  };

  return (
    <div className="flex items-center justify-center py-5 bg-[#EAF6FF] min-h-screen">
      <div className="bg-white p-8 rounded-lg shadow-sm w-96">
        <div className="flex items-center justify-center mb-6">
          <div className="bg-[#266AA9] p-2 rounded">
            <svg xmlns="http://www.w3.org/2000/svg" className="h-6 w-6 text-white" fill="none" viewBox="0 0 24 24" stroke="currentColor">
              <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M12 4v16m8-8H4" />
            </svg>
          </div>
          <h1 className="text-2xl font-semibold text-[#266AA9] ml-2">HealthCare</h1>
        </div>

        <h2 className="text-xl font-semibold text-center mb-4">Sign Up</h2>

        {/* Show success or error messages */}
        {successMessage && (
          <div className="alert alert-success mb-4">
            <svg xmlns="http://www.w3.org/2000/svg" className="h-6 w-6 shrink-0 stroke-current" fill="none" viewBox="0 0 24 24">
              <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M12 9v2m0 4h.01m-6.938 4h13.856c1.54 0 2.502-1.667 1.732-3L13.732 4c-.77-1.333-2.694-1.333-3.464 0L3.34 16c-.77 1.333.192 3 1.732 3z" />
            </svg>
            <span>{successMessage}</span>
          </div>
        )}
        {errorMessage && (
          <div className="alert alert-error mb-4">
            <svg xmlns="http://www.w3.org/2000/svg" className="h-6 w-6 shrink-0 stroke-current" fill="none" viewBox="0 0 24 24">
              <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M12 9v2m0 4h.01m-6.938 4h13.856c1.54 0 2.502-1.667 1.732-3L13.732 4c-.77-1.333-2.694-1.333-3.464 0L3.34 16c-.77 1.333.192 3 1.732 3z" />
            </svg>
            <span>{errorMessage}</span>
          </div>
        )}

        <div className="space-y-4">
          {!isCodeStep && (
            <>
              {['fullName', 'dob', 'phone', 'email', 'insurance', 'password'].map((field) => (
                <div key={field}>
                  <label className="label capitalize">{field.replace(/([A-Z])/g, ' $1')}</label>
                  <input
                    name={field}
                    type={field === 'dob' ? 'date' : field === 'password' ? 'password' : field === 'email' ? 'email' : 'text'}
                    placeholder={field.replace(/([A-Z])/g, ' $1')}
                    className="input input-bordered w-full"
                    value={(formData as any)[field]}
                    onChange={handleChange}
                  />
                </div>
              ))}
            </>
          )}

          {isCodeStep && (
            <>
              <div>
                <label className="label">Verification Code</label>
                <input
                  type="text"
                  placeholder="Enter code sent to email"
                  className="input input-bordered w-full"
                  value={codeInput}
                  onChange={(e) => setCodeInput(e.target.value)}
                />
              </div>

              <button
                onClick={handleResend}
                className="text-sm text-blue-500 underline mb-2"
              >
                Resend OTP
              </button>
            </>
          )}

          <button
            className="btn w-full text-white bg-[#266AA9] normal-case shadow-none border-none flex items-center justify-center"
            onClick={handleRegisterClick}
            disabled={loading}
          >
            {loading ? <span className="loading loading-dots loading-xs"></span> : isCodeStep ? 'Verify & Register' : 'Register'}
          </button>
        </div>
      </div>
    </div>
  );
};

export default Registration;
