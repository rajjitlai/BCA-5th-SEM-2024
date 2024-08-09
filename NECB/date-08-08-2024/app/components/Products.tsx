import { NextRequest, NextResponse } from 'next/server';
import React from 'react'

const products = require('../api/products/products.json')

const Products = () => {
    return (
        <div className='flex flex-col gap-3'>
            <h2 className='text-3xl'>Products</h2>
            <ul className='flex flex-col gap-3'>
                {products.map(({ id, name, category }) => (
                    <li key={id} className='text-xl flex flex-col gap-1'>{id}. {name}
                        <p className='text-green-400'>Category: <span className='text-white'>{category}</span></p>
                    </li>
                ))}
            </ul>
        </div>
    )
}

export default Products