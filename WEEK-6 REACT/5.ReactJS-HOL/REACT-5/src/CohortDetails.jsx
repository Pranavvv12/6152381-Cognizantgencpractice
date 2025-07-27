// CohortDetails.js

import React from 'react';
import styles from './CohortDetails.module.css';

function CohortDetails({ cohortName, startDate, status }) {
  const titleStyle = {
    color: status === 'ongoing' ? 'green' : 'blue'
  };

  return (
    <div className={styles.box}>
      <h3 style={titleStyle}>{cohortName}</h3>
      <dl>
        <dt>Start Date:</dt>
        <dd>{startDate}</dd>
        <dt>Status:</dt>
        <dd>{status}</dd>
      </dl>
    </div>
  );
}

export default CohortDetails;
