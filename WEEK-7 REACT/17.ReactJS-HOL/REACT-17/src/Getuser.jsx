import React, { Component } from 'react';

class Getuser extends Component {
  constructor(props) {
    super(props);
    this.state = {
      user: null,
      loading: true,
      error: null
    };
  }

  async componentDidMount() {
    try {
      const response = await fetch('https://api.randomuser.me/');
      const data = await response.json();
      const userData = data.results[0];

      this.setState({
        user: {
          title: userData.name.title,
          firstName: userData.name.first,
          image: userData.picture.large
        },
        loading: false
      });
    } catch (error) {
      this.setState({ error: 'Failed to fetch user', loading: false });
    }
  }

  render() {
    const { user, loading, error } = this.state;

    if (loading) return <p>Loading user...</p>;
    if (error) return <p style={{ color: 'red' }}>{error}</p>;

    return (
      <div style={{ textAlign: 'center', marginTop: '40px' }}>
        <h2>User Details</h2>
        <p><strong>Title:</strong> {user.title}</p>
        <p><strong>First Name:</strong> {user.firstName}</p>
        <img src={user.image} alt="User" style={{ borderRadius: '10px', width: '150px' }} />
      </div>
    );
  }
}

export default Getuser;
