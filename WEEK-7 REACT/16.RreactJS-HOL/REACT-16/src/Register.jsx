import React, { useState } from 'react';

function Register() {
  const [form, setForm] = useState({
    name: '',
    email: '',
    password: ''
  });

  const [errors, setErrors] = useState({});

  const validate = () => {
    let errs = {};

    if (form.name.trim().length < 5) {
      errs.name = "Name must be at least 5 characters.";
    }

    if (!form.email.includes('@') || !form.email.includes('.')) {
      errs.email = "Email must contain '@' and '.'.";
    }

    if (form.password.length < 8) {
      errs.password = "Password must be at least 8 characters.";
    }

    setErrors(errs);
    return Object.keys(errs).length === 0;
  };

  const handleChange = (e) => {
    setForm({
      ...form,
      [e.target.name]: e.target.value
    });
  };

  const handleSubmit = (e) => {
    e.preventDefault();

    if (validate()) {
      alert('Registration successful!');
      setForm({ name: '', email: '', password: '' });
      setErrors({});
    }
  };

  return (
    <div style={{ maxWidth: '400px', margin: 'auto', padding: '20px' }}>
      <h2>📧 Mail Register</h2>
      <form onSubmit={handleSubmit}>
        <div style={{ marginBottom: '10px' }}>
          <label>Name:</label><br />
          <input
            type="text"
            name="name"
            value={form.name}
            onChange={handleChange}
            style={{ width: '100%', padding: '8px' }}
          />
          {errors.name && <span style={{ color: 'red' }}>{errors.name}</span>}
        </div>

        <div style={{ marginBottom: '10px' }}>
          <label>Email:</label><br />
          <input
            type="email"
            name="email"
            value={form.email}
            onChange={handleChange}
            style={{ width: '100%', padding: '8px' }}
          />
          {errors.email && <span style={{ color: 'red' }}>{errors.email}</span>}
        </div>

        <div style={{ marginBottom: '10px' }}>
          <label>Password:</label><br />
          <input
            type="password"
            name="password"
            value={form.password}
            onChange={handleChange}
            style={{ width: '100%', padding: '8px' }}
          />
          {errors.password && <span style={{ color: 'red' }}>{errors.password}</span>}
        </div>

        <button type="submit" style={{ padding: '10px 20px' }}>
          Register
        </button>
      </form>
    </div>
  );
}

export default Register;
