import { NextRequest, NextResponse } from "next/server";

const data = [
    {
        id: '1',
        name: 'jack',
        department: 'cse'
    },
    {
        id: '2',
        name: 'jill',
        department: 'eee'
    }
]

export async function GET(req: NextRequest, { params }: { params: { id: string } }) {
    if (params.id == data[0].id) {
        return NextResponse.json(data[0])
    } else {
        return NextResponse.json({ status: 404, message: 'Id not found' })
    }
}