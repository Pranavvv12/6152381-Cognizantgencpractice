// Cart.jsx
import React from 'react';

class Cart extends React.Component {
  render() {
    const { itemname, price } = this.props;
    return (
      <div style={{ border: '1px solid black', padding: '10px', margin: '10px' }}>
        <h3>Item: {itemname}</h3>
        <p>Price: ₹{price}</p>
      </div>
    );
  }
}

export default Cart;
