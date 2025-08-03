import React, { Component } from 'react';

class CurrencyConverter extends Component {
  constructor(props) {
    super(props);
    this.state = {
      inr: '',
      euro: '',
    };

    this.handleChange = this.handleChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleChange(e) {
    this.setState({ inr: e.target.value });
  }

  handleSubmit(e) {
    e.preventDefault(); 
    const euroValue = (parseFloat(this.state.inr) / 90).toFixed(2); 
    this.setState({ euro: euroValue });
  }

  render() {
    return (
      <div>
        <h2>Currency Converter</h2>
        <form onSubmit={this.handleSubmit}>
          <input
            type="number"
            value={this.state.inr}
            onChange={this.handleChange}
            placeholder="Enter amount in INR"
          />
          <button type="submit">Convert</button>
        </form>
        <p>Euro: €{this.state.euro}</p>
      </div>
    );
  }
}

export default CurrencyConverter;
