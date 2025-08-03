import React, { useState } from 'react';
import EmployeesList from './EmployeesList';
import ThemeContext from './ThemeContext';

function App() {
  const [theme, setTheme] = useState('light');

  const toggleTheme = () =>
    setTheme(prev => (prev === 'light' ? 'dark' : 'light'));

  return (
    <ThemeContext.Provider value={theme}>
      <div style={{ padding: '20px', fontFamily: 'Arial' }}>
        <h1>🌐 Employee Management</h1>
        <button onClick={toggleTheme}>
          Toggle Theme (Current: {theme})
        </button>
        <EmployeesList />
      </div>
    </ThemeContext.Provider>
  );
}

export default App;
