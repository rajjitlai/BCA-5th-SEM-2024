import { NextRequest, NextResponse } from "next/server";

const products = require('../products.json')

export async function GET(req: NextRequest, { params }: { params: { pk: string } }) {
    const product = products.find((product: { id: string }) => product.id === params.pk);
    if (product) {
        return NextResponse.json(product);
    } else {
        return NextResponse.json({ status: 405, message: 'Product not found' });
    }
}
