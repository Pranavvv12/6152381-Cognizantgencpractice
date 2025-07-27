// App.jsx
import React from 'react';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';
import Home from './Home.jsx';
import TrainersList from './TrainersList.jsx';
import TrainerDetails from './TrainerDetails.jsx';
import TrainersMock from './TrainersMock.jsx';

function App() {
  return (
    <Router>
      <div style={{ padding: '20px' }}>
        <h1>TrainersApp</h1>
        <nav style={{ marginBottom: '20px' }}>
          <Link to="/" style={{ marginRight: '15px' }}>Home</Link>
          <Link to="/trainers">Trainers</Link>
        </nav>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/trainers" element={<TrainersList data={TrainersMock} />} />
          <Route path="/trainer/:id" element={<TrainerDetails />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
