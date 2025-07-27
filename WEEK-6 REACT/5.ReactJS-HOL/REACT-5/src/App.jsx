
import React from 'react';
import CohortDetails from './CohortDetails';

function App() {
  return (
    <div>
      <h1>My Academy Dashboard</h1>

      <CohortDetails
        cohortName="React Cohort 2025"
        startDate="July 2025"
        status="ongoing"
      />

      <CohortDetails
        cohortName="NodeJS Cohort 2024"
        startDate="March 2024"
        status="completed"
      />
    </div>
  );
}

export default App;
