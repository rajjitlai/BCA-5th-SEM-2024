import React from 'react'

const product = require("../api/products/products.json")

const Products = () => {
  return (
    <div>
      <h2 className='text-3xl'>Products</h2>
      <ul>
        <li>
          {
            product.map(({ id, name, category }) => {
              return (
                <div key={id}>
                  <p>{id}. {name}</p>
                  <p className='text-green-300'>
                    Category: 
                    <span className='text-white'>
                      {category}
                    </span>
                  </p>
                </div>
              )
            })
          }
        </li>
      </ul>
    </div>
  )
}

export default Products