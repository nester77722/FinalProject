import React, { Component } from "react";
import axios from "axios";
import UserService from "../services/user.service";
import EventBus from "../common/EventBus";

export default class BoardUser extends Component {
    constructor(props) {
        super(props);

        this.state = {
            orders: null,
            userName: props.userName
        };
        this.loadOrders = this.loadOrders.bind(this);
    }
    componentDidMount() {
        this.loadOrders();
    }

    async loadOrders() {
        await axios.get('https://localhost:44382/api/order' + this.state.userName, {
            params: {
                userName: this.state.userName
            }
        })
            .then(function (response) {
                this.setState({ orders: response.data.orders, totalOrders: response.data.totalOrders });
            }.bind(this))
            .catch(function (error) {
                console.log(error);
            });
    }

  render() {
    return (
      <div className="container">
        <header className="jumbotron">
          <h3>{this.state.content}</h3>
        </header>
      </div>
    );
  }
}
