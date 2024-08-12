import React from 'react'
import Users from './components/Users'
import Products from './components/Products'

const Home = () => {
  return (
    <main className='w-full h-screen flex items-center justify-center gap-5'>
      <Users />
      <Products />
    </main>
  )
}

export default Home