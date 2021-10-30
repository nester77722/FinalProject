import React from 'react';
import Pagination from "./Pagination";
import axios from 'axios';

export default class Products extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            products: null,
            imagesPaths: null,
            totalProducts: 0,
            pageSize: 10
        };
        this.loadProducts = this.loadProducts.bind(this);
    }

    componentDidMount() {
        this.loadProducts();
    }

    redirect = (id) => {
        this.props.history.push({
            pathname: "/product",
            state: {
                productId: id
            }
        });
    }

    async loadProducts(currentPage = 1) {
        await axios.get('https://localhost:44382/api/product/all-products', {
            params: {
                page: currentPage,
                pageSize: this.state.pageSize
            }
        })
            .then(function (response) {
                this.setState({ products: response.data.products, totalProducts: response.data.totalProducts });
            }.bind(this))
            .catch(function (error) {
                console.log(error);
            });
    }

    render() {
        let mappedProducts;
        if (this.state.products !== null) {
            mappedProducts = this.state.products.map(product => {
                return <div className="product">                    
                    <span className="product-text">{product.name}</span><br />
                    <button className="view-products-button" onClick={() => this.redirect(product.id)}>Show info</button>
                </div>
            }
            )
        }
        else mappedProducts = <span>Loading</span>

        return <div>
            <div className="products">
                {mappedProducts}
            </div> <br />
            <Pagination
                totalElements={this.state.totalProducts}
                pageSize={this.state.pageSize}
                changePage={this.loadProducts} />
        </div>
    }
}