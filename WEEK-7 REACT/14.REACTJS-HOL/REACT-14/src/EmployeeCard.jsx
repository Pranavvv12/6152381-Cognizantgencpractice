import React, { useContext } from 'react';
import ThemeContext from './ThemeContext';

function EmployeeCard({ name, position }) {
  const theme = useContext(ThemeContext);

  const buttonStyle = {
    backgroundColor: theme === 'dark' ? '#333' : '#eee',
    color: theme === 'dark' ? '#fff' : '#000',
    border: '1px solid #ccc',
    padding: '10px 20px',
    marginTop: '10px'
  };

  return (
    <div style={{ marginBottom: '15px' }}>
      <h4>{name}</h4>
      <p>{position}</p>
      <button style={buttonStyle}>View Profile</button>
    </div>
  );
}

export default EmployeeCard;
