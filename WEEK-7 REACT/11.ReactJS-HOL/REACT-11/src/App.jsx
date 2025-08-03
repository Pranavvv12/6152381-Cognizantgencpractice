import React, { Component } from 'react';
import CurrencyConverter from './CurrencyConverter';

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      counter: 0,
    };

    this.increment = this.increment.bind(this);
    this.decrement = this.decrement.bind(this);
    this.sayHello = this.sayHello.bind(this);
    this.sayWelcome = this.sayWelcome.bind(this);
    this.handleClick = this.handleClick.bind(this);
  }

  increment() {
    this.setState({ counter: this.state.counter + 1 });
    this.sayHello(); 
  }

  decrement() {
    this.setState({ counter: this.state.counter - 1 });
  }

  sayHello() {
    alert('Hello! This is a static message.');
  }

  sayWelcome(message) {
    alert(message);
  }

  handleClick(e) {
    e.preventDefault(); 
    alert("I was clicked");
  }

  render() {
    return (
      <div style={{ padding: '20px', fontFamily: 'Arial' }}>
        <h1>React Event Handling Lab</h1>
        
        <h2>Counter: {this.state.counter}</h2>
        <button onClick={this.increment}>Increment</button>{' '}
        <button onClick={this.decrement}>Decrement</button>

        <hr />

        <button onClick={() => this.sayWelcome("Welcome to the React Event Lab!")}>
          Say Welcome
        </button>

        <hr />

        <button onClick={this.handleClick}>Synthetic Event: OnPress</button>

        <hr />

        <CurrencyConverter />
      </div>
    );
  }
}

export default App;
