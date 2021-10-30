import React from "react";
import { BrowserRouter, Switch, Route } from "react-router-dom";
import Products from "./Products";

class Content extends React.Component {
    render() {
        return <div>
            <BrowserRouter>
                <Switch>
                    <Route path="/" exact component={Products} />
                    <Route path="/product" render={
                        (props) => <Product {...props} />
                    }/>
                </Switch>
            </BrowserRouter>
        </div>

    }
}

export default Content;
