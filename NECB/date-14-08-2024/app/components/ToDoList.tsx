"use client"

import React, { useEffect, useState } from 'react'

const deleteItem = async (id: string) => {
    try {
        const response = await fetch(`/api/todo/${id}`, {
            method: 'DELETE',
        });
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
    } catch (error) {
        console.error('Failed to delete item', error);
    }
}

const ToDoList = () => {
    const [data, setData] = useState<any[]>([])
    const [loading, setLoading] = useState<boolean>(true)
    const [error, setError] = useState<string | null>(null)

    useEffect(() => {
        const fetchItems = async () => {
            try {
                const response = await fetch('/api/todo');
                const data = await response.json();

                if (data.todoData && Array.isArray(data.todoData)) {
                    setData(data.todoData);
                } else {
                    setError('Invalid data format');
                }
            } catch (error) {
                setError('Failed to fetch data');
            } finally {
                setLoading(false);
            }
        };

        fetchItems();
    }, []);

    if (loading) return <div>Loading...</div>;
    if (error) return <div>Error: {error}</div>;

    return (
        <div className='max-w-[80%] m-auto'>
            <h1 className='text-3xl text-cyan-400'>My TODO Lists</h1>
            {/* display the todo list using the GET */}
            <div className='flex flex-col gap-10 mt-5'>
                {data.map((item) => (
                    <div key={item.id} className='text-xl'>
                        <p>Title: {item.name}</p>
                        <p>Info: {item.description}</p>
                        <p>Time: {item.createdAt}</p>
                        <div className='flex flex-row gap-5 mt-2'>
                            <button onClick={() => deleteItem(item.id)} className='bg-slate-50 text-black p-1 rounded'>Delete</button>
                            <button className='bg-slate-400 text-black p-1 rounded'>Edit</button>
                        </div>
                    </div>
                ))}
            </div>
        </div>
    )
}

export default ToDoList