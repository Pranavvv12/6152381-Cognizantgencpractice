import React, { Component } from 'react';

const GuestPage = () => (
  <div>
    <h2>Welcome, Guest! ✈️</h2>
    <p>Here are the available flights:</p>
    <ul>
      <li>Chennai → Delhi - ₹5000</li>
      <li>Bangalore → Mumbai - ₹4500</li>
      <li>Hyderabad → Kolkata - ₹4800</li>
    </ul>
    <p>Please login to book your tickets.</p>
  </div>
);

const UserPage = () => (
  <div>
    <h2>Welcome, User! ✅</h2>
    <p>You can now book your flight tickets:</p>
    <button>Book Ticket</button>
  </div>
);

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      isLoggedIn: false
    };
  }

  loginHandler = () => {
    this.setState({ isLoggedIn: true });
  };

  logoutHandler = () => {
    this.setState({ isLoggedIn: false });
  };

  render() {
    let content;
    let button;

    if (this.state.isLoggedIn) {
      content = <UserPage />;
      button = <button onClick={this.logoutHandler}>Logout</button>;
    } else {
      content = <GuestPage />;
      button = <button onClick={this.loginHandler}>Login</button>;
    }

    return (
      <div style={{ padding: '20px', fontFamily: 'Arial' }}>
        <h1>🎫 Ticket Booking App</h1>
        {button}
        <hr />
        {content}
      </div>
    );
  }
}

export default App;
