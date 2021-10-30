import React from "react";

import './Pagination.css'

const Pagination = ({totalElements, pageSize, changePage}) => {
    const numbers = [];

    for(let i = 1; i <= Math.ceil(totalElements / pageSize); i++){
        numbers.push(i);
    }
    
    return(
        <div className="pagination">
            {numbers.map(number => {
                return <button className="buttons" id={number} onClick={() => changePage(number)}>{number}</button>
            })}
        </div>
    )
}

export default Pagination;
