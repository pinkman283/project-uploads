'use client';

import { Router } from 'lucide-react';
import React, { useState } from 'react';
import { useRouter } from 'next/navigation';


const FeedbackPage = () => {
  const [comment, setComment] = useState(''); 
  const [rating, setRating] = useState<number>(0); 
  const [error, setError] = useState<string>(''); 
  const [success, setSuccess] = useState<string>(''); 
  const [loading, setLoading] = useState<boolean>(false); 
  const router = useRouter();
  const [loadingPage, setLoadingPage] = useState(false); 
  

  const handleCommentChange = (e: React.ChangeEvent<HTMLTextAreaElement>) => {
    setComment(e.target.value);
  };

  const handleRatingChange = (e: React.ChangeEvent<HTMLSelectElement>) => {
    setRating(Number(e.target.value));
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();

    
    if (!comment || rating === 0) {
      setError('Both comment and rating are required!');
      return;
    }

    const phone = localStorage.getItem('phone');
    if (!phone) {
      setError('User phone number not found.');
      return;
    }

    const payload = {
      comment,
      rating,
      phone_number: phone,
    };

    const token = localStorage.getItem('token');
    if (!token) {
      setError('No authentication token found.');
      return;
    }

    setLoading(true); 

    try {
      const response = await fetch('http://localhost:4000/feedback/submit-feedback', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
          'Authorization': `Bearer ${token}`, 
        },
        body: JSON.stringify(payload),
      });

      const data = await response.text(); 
      console.log('Response:', data); 

      if (response.ok) {
        setSuccess('Feedback submitted successfully!');
      } else {
        setError(data || 'Something went wrong!');
      }
    } catch (error) {
      console.error('Error:', error);
      setError('Failed to submit feedback');
    } finally {
      setLoading(false); 
    }
  };
   const handleNavigation = (href: string) => {
    setLoadingPage(true);
    setTimeout(() => {
      router.push (href);  
    }, 1000); 
  };

  return (
    <div className="min-h-screen flex justify-center items-center bg-gray-100 p-6">
      <div className="w-full max-w-lg bg-white rounded-lg shadow-md p-6 space-y-6">
        <h2 className="text-2xl font-semibold text-center text-blue-600">Feedback</h2>

        {error && <p className="text-red-500">{error}</p>}
        {success && <p className="text-green-500">{success}</p>}

        {/* Comment input */}
        <div>
          <label htmlFor="comment" className="block text-lg font-medium text-gray-700">Your Comment</label>
          <textarea
            id="comment"
            value={comment}
            onChange={handleCommentChange}
            rows={4}
            className="input input-bordered w-full mt-2"
            placeholder="Write your feedback here"
          ></textarea>
        </div>

        {/* Rating input */}
        <div>
          <label htmlFor="rating" className="block text-lg font-medium text-gray-700">Rating (1 to 5)</label>
          <select
            id="rating"
            value={rating}
            onChange={handleRatingChange}
            className="input input-bordered w-full mt-2"
          >
            <option value={0}>Select Rating</option>
            <option value={1}>1 - Poor</option>
            <option value={2}>2 - Fair</option>
            <option value={3}>3 - Good</option>
            <option value={4}>4 - Very Good</option>
            <option value={5}>5 - Excellent</option>
          </select>
        </div>

        {/* Submit button */}
        <div className="flex gap-x-4">
          <button
            onClick={handleSubmit}
            className="btn btn-primary text-white bg-blue-600 hover:bg-blue-700 px-6 py-2 rounded-md transition duration-300"
            disabled={loading} 
          >
            {loading ? 'Submitting...' : 'Submit Feedback'}
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

export default FeedbackPage;
