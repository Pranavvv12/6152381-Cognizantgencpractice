import React, { useState } from 'react';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';

function App() {
  const [activeTab, setActiveTab] = useState('book');
  let content;
  if (activeTab === 'book') {
    content = <BookDetails />;
  } else if (activeTab === 'blog') {
    content = <BlogDetails />;
  } else {
    content = <CourseDetails />;
  }

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      <h1>🧠 Blogger App</h1>

      {/* Buttons */}
      <button onClick={() => setActiveTab('book')}>Show Book</button>
      <button onClick={() => setActiveTab('blog')}>Show Blog</button>
      <button onClick={() => setActiveTab('course')}>Show Course</button>

      <hr />

      {content}

      <hr />
      <h3>Rendered with Ternary:</h3>
      {
        activeTab === 'book' ? <BookDetails /> :
        activeTab === 'blog' ? <BlogDetails /> :
        <CourseDetails />
      }

      <hr />
      <h3>Rendered with Logical AND:</h3>
      {activeTab === 'book' && <BookDetails />}
      {activeTab === 'blog' && <BlogDetails />}
      {activeTab === 'course' && <CourseDetails />}
    </div>
  );
}

export default App;
