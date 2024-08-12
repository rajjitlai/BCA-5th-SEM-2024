import React from 'react'

const users = require("../api/users/users.json")

const Users = () => {
  return (
    <div>
      <h2 className='text-3xl'>Users</h2>
      <ul>
        <li>
          {
            users.map(({ id, name, category }) => {
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

export default Users