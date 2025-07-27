import React, { Component } from 'react';
import Post from './Post'; // ✅ Required for rendering each post

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      hasError: false
    };
  }

  componentDidMount() {
    this.loadPosts();
  }

  loadPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then((response) => response.json())
      .then((data) => this.setState({ posts: data.slice(0, 10) }))
      .catch((error) => {
        console.error("Error fetching posts:", error);
        this.setState({ hasError: true });
      });
  }

  componentDidCatch(error, info) {
    alert('An error occurred while loading the posts.');
    console.error("Error caught:", error, info);
    this.setState({ hasError: true });
  }

  render() {
    if (this.state.hasError) {
      return <h2>Error loading posts.</h2>;
    }

    return (
      <div>
        <h2>Posts List</h2>
        {this.state.posts.map(post => (
          <Post key={post.id} title={post.title} body={post.body} />
        ))}
      </div>
    );
  }
}

export default Posts;
