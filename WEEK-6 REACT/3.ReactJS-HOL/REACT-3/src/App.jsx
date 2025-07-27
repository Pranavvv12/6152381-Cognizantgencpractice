import React from 'react';
import CalculateScore from '../src/components/CalculateScore.jsx';

function App() {
  return (
    <div>
      <CalculateScore Name="Pranav Kumar" School="Saveetha Engineering College" total={450} goal={5} />
    </div>
  );
}

export default App;
