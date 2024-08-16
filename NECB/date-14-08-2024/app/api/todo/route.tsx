import { NextRequest, NextResponse } from "next/server";
import todoData from "@/app/api/todo/todo.json"

// get random id
import { v4 as uuidv4 } from 'uuid';

// get the date
const date = new Date().toISOString()

// get the todo list
// export async function GET() {
//     return NextResponse.json({ status: 200, message: "Success", todoData })
// }

// add the Todo item
export async function POST(req: NextRequest) {
    const data = await req.json();
    const addData = {
        id: uuidv4(),
        name: data.name,
        description: data.description,
        createdAt: date,
        updatedAt: date,
    }
    todoData.push(addData);
    return NextResponse.json({ status: 200, message: "Task added successfully" })
}

export async function GET(req: NextRequest) {
    const url = req.url;
    console.log(url)

    const searchParams = new URL(url).searchParams;
    const name = searchParams.get('query');

    if (name) {
        const filteredData = todoData.filter((item: any) => item.name.toLowerCase().includes(name.toLowerCase()));
        return NextResponse.json({ status: 200, message: "Success", data: filteredData })
    }
}