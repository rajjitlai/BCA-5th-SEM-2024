import { NextRequest, NextResponse } from "next/server";
import todoData from "@/app/api/todo/todo.json"

const date = new Date().toISOString()

// update the Todo item
export async function PUT(req: NextRequest, { params }: { params: { id: string } }) {
    const data = await req.json();
    const index = todoData.findIndex(item => item.id === params.id);
    const updateData = {
        id: params.id,
        name: data.name,
        description: data.description,
        createdAt: todoData[index].createdAt,
        updatedAt: date,
    }

    if (!index) {
        return NextResponse.json({ status: 404, message: "Task not found" })
    } else {
        todoData[index] = updateData
        return NextResponse.json({status: 200, message: "Task updated successfully"})
    }
}

// delete the Todo item
export async function DELETE(req: NextRequest, {params}: {params: {id: string}}){
    const data = await req.json();
    const index = todoData.findIndex((delData: any) => delData.id === params.id)

    if(index !== -1){
        todoData.splice(index, 1)
        return NextResponse.json({status: 200, message: "Task deleted successfully"})
    }else{
        return NextResponse.json({status: 404, message: "Task not found"})
    }
}