import axios from "axios";
import React from "react";

import './Products.css'

class Product extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            productId: props.history.location.state.productId,
            productName: null,
            price: null,
            description: null,
            productImages: null
        }

        this.loadProduct = this.loadProduct.bind(this);
        this.loadProductImages = this.loadProductImages.bind(this);
    }

    componentDidMount() {
        this.loadProduct();
    }

    async loadProduct() {
        await axios.get('https://localhost:44382/api/product/get-specific-product', {
            params: {
                id: this.state.productId
            }
        })
            .then(function (response) {
                this.setState({ productName: response.data.name, price: response.data.price, description: response.data.description });
            }.bind(this))
            .catch(function (error) {
                console.log(error);
            });
    }

    async loadProductImages() {
        await axios.get('https://localhost:44382/api/product/images', {
            params: {
                productId: this.state.productId
            }
        })
            .then(function (response) {
                this.setState({ productImages: response.data });
            }.bind(this))
            .catch(function (error) {
                console.log(error);
            });
    }

    render() {

        return <div>
            <div className="products">
            </div>
            <div className="product">
                <span>Name: {this.state.productName}</span> <br />
                <span>Description: {this.state.description}</span> <br />
                <span>Price: {this.state.price}</span> <br />
                <button className="add-to-cart-buttons">Add to cart</button>
            </div>
        </div>
    }
}
export default Product;