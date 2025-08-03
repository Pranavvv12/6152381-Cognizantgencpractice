import React from 'react';

const ListOfPlayers = () => {
  const players = [
    { name: "Virat", score: 80 },
    { name: "Rohit", score: 60 },
    { name: "Rahul", score: 90 },
    { name: "Dhoni", score: 65 },
    { name: "Jadeja", score: 75 },
    { name: "Bumrah", score: 85 },
    { name: "Ashwin", score: 45 },
    { name: "Shami", score: 55 },
    { name: "Pant", score: 50 },
    { name: "Iyer", score: 95 },
    { name: "Gill", score: 70 },
  ];

  const topPlayers = players.map(player => (
    <li key={player.name}>
      {player.name} - {player.score}
    </li>
  ));

  const lowScorers = players.filter(p => p.score < 70).map(player => (
    <li key={player.name}>
      {player.name} - {player.score}
    </li>
  ));

  return (
    <div>
      <h2>All Players</h2>
      <ul>{topPlayers}</ul>

      <h2>Players with Score Below 70</h2>
      <ul>{lowScorers}</ul>
    </div>
  );
};

export default ListOfPlayers;
