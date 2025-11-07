'use client'
import React, { useState } from 'react'

const Fieldset = ({
  phone,
  password,
  error,
  setPhone,
  setPassword,
  handleLogin
}: {
  phone: string
  password: string
  error: string
  setPhone: (val: string) => void
  setPassword: (val: string) => void
  handleLogin: (e: React.FormEvent) => void
}) => {
  const [loading, setLoading] = useState(false);

  const handleSubmit = async (e: React.FormEvent) => {
    setLoading(true);
    await handleLogin(e); 
    setLoading(false); 
  };

  return (
    <div className="flex items-center justify-center py-5">
      <div className="bg-white p-8 rounded-lg shadow-sm w-96">

        {/* Logo + HealthCare Title */}
        <div className="flex items-center justify-center mb-6">
          <div className="bg-[#266AA9] p-2 rounded">
            <svg xmlns="http://www.w3.org/2000/svg" className="h-6 w-6 text-white" fill="none" viewBox="0 0 24 24" stroke="currentColor">
              <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M12 4v16m8-8H4" />
            </svg>
          </div>
          <h1 className="text-2xl font-semibold text-[#266AA9] ml-2">HealthCare</h1>
        </div>

        <h2 className="text-xl font-semibold text-center mb-4">Login</h2>

        {error && <p className="text-red-500 text-sm text-center mb-2">{error}</p>}

        <form onSubmit={handleSubmit} className="space-y-4">
          <div>
            <label className="label">Phone Number</label>
            <input
              type="text"
              placeholder="Phone Number"
              className="input input-bordered w-full"
              value={phone}
              onChange={(e) => setPhone(e.target.value)}
              required
            />
          </div>

          <div>
            <label className="label">Password</label>
            <input
              type="password"
              placeholder="Password"
              className="input input-bordered w-full"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              required
            />
          </div>

          <button
            type="submit"
            className="btn w-full text-white bg-[#266AA9] normal-case shadow-none border-none flex items-center justify-center"
            disabled={loading} 
          >
            {loading ? (
              <span className="loading loading-dots loading-xs"></span> 
            ) : (
              'Login'
            )}
          </button>

          <div className="text-center mt-3">
            <a href="/forgetpassword" className="text-sm text-[#266AA9] hover:underline">Forgot Password?</a>
            <br />
            <span className="text-sm">
              Don’t have an account?{" "}
              <a href="/register" className="text-[#266AA9] hover:underline">Sign Up</a>
            </span>
          </div>
        </form>
      </div>
    </div>
  )
}

export default Fieldset;
