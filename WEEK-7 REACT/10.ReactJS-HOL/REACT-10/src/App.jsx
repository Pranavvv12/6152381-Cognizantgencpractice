import React from 'react';

function App() {
 
  const office = {
    name: "SmartSpace Co-working",
    rent: 55000,
    address: "Anna Salai, Chennai",
    image: "download.jpeg" 
  };

  const officeList = [
    { name: "TechHub", rent: 40000, address: "T Nagar, Chennai" },
    { name: "InnovateSpace", rent: 62000, address: "Guindy, Chennai" },
    { name: "WorkNest", rent: 58000, address: "Adyar, Chennai" },
    { name: "StartupZone", rent: 75000, address: "Velachery, Chennai" }
  ];

  const getRentStyle = (rent) => ({
    color: rent < 60000 ? "red" : "green",
    fontWeight: "bold"
  });

  return (
    <div style={{ padding: "20px", fontFamily: "Arial" }}>
      <h1>🏢 Office Space Rental</h1>

      <img src={office.image} alt="Office" width="300" style={{ marginBottom: "20px" }} />

      <h2>Featured Office</h2>
      <p><strong>Name:</strong> {office.name}</p>
      <p><strong>Address:</strong> {office.address}</p>
      <p>
        <strong>Rent:</strong>{' '}
        <span style={getRentStyle(office.rent)}>₹{office.rent}</span>
      </p>

      <hr />

      <h2>Available Office Spaces</h2>
      <ul>
        {officeList.map((off, index) => (
          <li key={index} style={{ marginBottom: "15px" }}>
            <p><strong>Name:</strong> {off.name}</p>
            <p><strong>Address:</strong> {off.address}</p>
            <p>
              <strong>Rent:</strong>{' '}
              <span style={getRentStyle(off.rent)}>₹{off.rent}</span>
            </p>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
