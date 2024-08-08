import { NextResponse } from "next/server"

const products = require('./products.json')

export async function GET() {
    return NextResponse.json(products, { status: 200 })
}