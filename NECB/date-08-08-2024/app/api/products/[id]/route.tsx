import { NextRequest, NextResponse } from "next/server";

const products = [
    {
        id: '1',
        name: 'apple',
        category: 'fruit',
    },
    {
        id: '2',
        name: 'orange',
        category: 'fruit'
    },
    {
        id: '3',
        name: 'banana',
        category: 'fruit'
    },
    {
        id: '4',
        name: 'mango',
        category: 'fruit'
    }
];

export async function GET(req: NextRequest, { params }: { params: { id: string } }) {
    const product = products.find(product => product.id === params.id);

    if (product) {
        return NextResponse.json(product);
    } else {
        return NextResponse.json({ status: 404, message: 'Id not found' });
    }
}
