import { NextRequest, NextResponse } from "next/server";

const products = require('../products.json')
const users = require('../../users/users.json')

// export async function GET(req: NextRequest, { params }: { params: { pk: string } }) {
//     const product = products.find((product: { id: string }) => product.id === params.pk);
//     if (product) {
//         return NextResponse.json(product);
//     } else {
//         return NextResponse.json({ status: 405, message: 'Product not found' });
//     }
// }

export async function GET(req: NextRequest, { params }: { params: { id: string } }) {
    console.log("Received params:", params);

    const product = products.find((p: any) => p.id === params.id);
    console.log("Found product:", product);

    if (!product) {
        return NextResponse.json({ message: 'Product not found' }, { status: 404 });
    }

    const productCategory = product.category;
    console.log("Product category:", productCategory);

    const matchingUsers = users.filter((user: any) => user.category === productCategory);
    console.log("Matching users:", matchingUsers);

    return NextResponse.json({ product, users: matchingUsers }, { status: 200 });
}