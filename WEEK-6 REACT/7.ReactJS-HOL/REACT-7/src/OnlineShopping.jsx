// OnlineShopping.jsx
import React from 'react';
import Cart from './Cart.jsx';

class OnlineShopping extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      items: [
        { itemname: "Laptop", price: 50000 },
        { itemname: "Smartphone", price: 20000 },
        { itemname: "Headphones", price: 1500 },
        { itemname: "Keyboard", price: 700 },
        { itemname: "Mouse", price: 400 }
      ]
    };
  }

  render() {
    return (
      <div>
        <h2>Online Shopping Cart</h2>
        {this.state.items.map((item, index) => (
          <Cart key={index} itemname={item.itemname} price={item.price} />
        ))}
      </div>
    );
  }
}

export default OnlineShopping;
