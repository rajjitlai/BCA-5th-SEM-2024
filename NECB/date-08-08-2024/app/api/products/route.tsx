import { NextRequest, NextResponse } from "next/server"

const products = require('./products.json')

export async function GET() {
    return NextResponse.json(products, { status: 200 })
}

export async function POST(req: NextRequest) {
    const body = await req.json();
    products.push(body);
    console.log(body);
    return NextResponse.json(body, { status: 200 });
}