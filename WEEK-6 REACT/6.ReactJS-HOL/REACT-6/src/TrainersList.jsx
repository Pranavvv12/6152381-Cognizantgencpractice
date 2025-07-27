// TrainersList.jsx
import React from 'react';
import { Link } from 'react-router-dom';

function TrainersList({ data }) {
  return (
    <div>
      <h2>Trainers List</h2>
      <ul>
        {data.map(trainer => (
          <li key={trainer.TrainerId}>
            <Link to={`/trainer/${trainer.TrainerId}`}>{trainer.Name}</Link>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default TrainersList;
