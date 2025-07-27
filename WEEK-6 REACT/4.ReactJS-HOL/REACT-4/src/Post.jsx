// src/Post.js

import React from 'react';

function Post({ title, body }) {
  return (
    <div style={{ border: "1px solid gray", padding: "10px", margin: "10px" }}>
      <h3>{title}</h3>
      <p>{body}</p>
    </div>
  );
}

export default Post;
