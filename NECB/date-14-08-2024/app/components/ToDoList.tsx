"use client"

import React, { useEffect, useState } from 'react'

const ToDoList = () => {
    const [data, setData] = useState<any[]>([])
    const [loading, setLoading] = useState<boolean>(true)
    const [error, setError] = useState<string | null>(null)

    useEffect(() => {
        const fetchItems = async () => {
            try {
                const response = await fetch('/api/todo');
                const data = await response.json();

                console.log("Fetched data:", data);
                // console.log("Data type:", typeof data);
                // console.log("Is data an array?", Array.isArray(data));

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
            <div className=''>
                {data.map((item) => (
                    <div key={item.id}>
                        <p>Title: {item.name}</p>
                        <p>Info: {item.description}</p>
                        <p>Time: {item.createdAt}</p>
                    </div>
                ))}
            </div>
            {/* add new item */}
            <div className=''></div>
            {/* update item */}
            <div className=''></div>
            {/* delete item */}
            <div className=''></div>
        </div>
    )
}

export default ToDoList