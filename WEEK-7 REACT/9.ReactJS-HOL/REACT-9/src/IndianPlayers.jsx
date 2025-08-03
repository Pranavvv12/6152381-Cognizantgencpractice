import React from 'react';

const IndianPlayers = () => {
  const team = ["Kohli", "Rohit", "Rahul", "Dhawan", "Jadeja", "Ashwin", "Shami", "Pant"];

  const oddTeam = team.filter((_, index) => index % 2 !== 0);
  const evenTeam = team.filter((_, index) => index % 2 === 0);

  const T20Players = ["Surya", "Hardik"];
  const RanjiPlayers = ["Pujara", "Rahane"];
  const mergedPlayers = [...T20Players, ...RanjiPlayers];

  return (
    <div>
      <h2>Even Team Players</h2>
      <ul>{evenTeam.map(player => <li key={player}>{player}</li>)}</ul>

      <h2>Odd Team Players</h2>
      <ul>{oddTeam.map(player => <li key={player}>{player}</li>)}</ul>

      <h2>Merged T20 + Ranji Players</h2>
      <ul>{mergedPlayers.map(player => <li key={player}>{player}</li>)}</ul>
    </div>
  );
};

export default IndianPlayers;
