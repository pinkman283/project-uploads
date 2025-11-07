import React, { useState } from 'react'

const ForgetPassword = () => {
  const [step, setStep] = useState<'email' | 'code' | 'reset'>('email');
  const [email, setEmail] = useState('');
  const [code, setCode] = useState('');
  const [inputCode, setInputCode] = useState('');
  const [newPassword, setNewPassword] = useState('');
  const [alert, setAlert] = useState<string | null>(null);

  const handleSendCode = (e: React.FormEvent) => {
    e.preventDefault();
    if (!email.includes('@')) {
      setAlert('Please enter a valid email address.');
      return;
    }
    const generatedCode = '123456'; 
    setCode(generatedCode);
    setAlert(`A verification code has been sent to ${email}`);
    setStep('code');
  };

  const handleVerifyCode = (e: React.FormEvent) => {
    e.preventDefault();
    if (inputCode === code) {
      setAlert('Code verified! You can now set a new password.');
      setStep('reset');
    } else {
      setAlert('Incorrect code. Please try again.');
    }
  };

  const handleResetPassword = (e: React.FormEvent) => {
    e.preventDefault();
    setAlert('Password successfully reset! Redirecting to login...');
    setTimeout(() => {
      window.location.href = '/login';
    }, 2000);
  };

  return (
    <div className="min-h-screen flex items-center justify-center bg-base-200 p-4">
      <div className="bg-white shadow-md rounded-lg p-6 w-full max-w-md">
        <h1 className="text-2xl font-bold mb-4 text-center text-[#266AA9]">Forgot Password</h1>

        {alert && (
          <div role="alert" className="alert alert-info mb-4">
            <span>{alert}</span>
          </div>
        )}

        {step === 'email' && (
          <form onSubmit={handleSendCode} className="space-y-3">
            <input
              type="email"
              placeholder="Enter your email"
              className="input input-bordered w-full"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              required
            />
            <button type="submit" className="btn btn-primary w-full">
              Send Verification Code
            </button>
          </form>
        )}

        {step === 'code' && (
          <form onSubmit={handleVerifyCode} className="space-y-3">
            <input
              type="text"
              placeholder="Enter the verification code"
              className="input input-bordered w-full"
              value={inputCode}
              onChange={(e) => setInputCode(e.target.value)}
              required
            />
            <button type="submit" className="btn btn-primary w-full">
              Verify Code
            </button>
          </form>
        )}

        {step === 'reset' && (
          <form onSubmit={handleResetPassword} className="space-y-3">
            <input
              type="password"
              placeholder="Enter new password"
              className="input input-bordered w-full"
              value={newPassword}
              onChange={(e) => setNewPassword(e.target.value)}
              required
            />
            <button type="submit" className="btn btn-success w-full">
              Set New Password
            </button>
          </form>
        )}
      </div>
    </div>
  );
}

export default ForgetPassword