import React from 'react';
import EmployeeCard from './EmployeeCard';

const employeeData = [
  { id: 1, name: 'Alice', position: 'Developer' },
  { id: 2, name: 'Bob', position: 'Designer' },
  { id: 3, name: 'Charlie', position: 'Manager' },
];

function EmployeesList() {
  return (
    <div style={{ marginTop: '20px' }}>
      <h2>Employee List</h2>
      {employeeData.map(emp => (
        <EmployeeCard key={emp.id} name={emp.name} position={emp.position} />
      ))}
    </div>
  );
}

export default EmployeesList;
