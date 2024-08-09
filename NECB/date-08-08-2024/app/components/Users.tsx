import React from 'react'
import { NextRequest, NextResponse } from 'next/server'

const users = require('../api/users/users.json')

const Users = () => {
    return (
        <div className='flex flex-col gap-3'>
            <h2 className='text-3xl'>Users</h2>
            <ul className='flex flex-col gap-3'>
                {users.map(({ id, name, category }) => (
                    <li key={id} className='text-xl flex flex-col gap-1'>{id}. {name}
                        <p className='text-green-400'>Category: <span className='text-white'>{category}</span></p>
                    </li>
                ))}
            </ul>
        </div>
    )
}

export default Users