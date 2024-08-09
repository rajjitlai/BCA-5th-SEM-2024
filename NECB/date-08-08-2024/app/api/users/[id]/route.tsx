import { NextRequest, NextResponse } from "next/server";

const users = require('../users.json')
const products = require('../../products/products.json')

// export async function GET(req: NextRequest, { params }: { params: { id: string } }) {
//     if (params.id == data[0].id) {
//         return NextResponse.json(data[0])
//     } else {
//         return NextResponse.json({ status: 404, message: 'Id not found' })
//     }
// }

export async function GET(req: NextRequest, { params }: { params: { id: string } }) {
    const userId = params.id;
    const user = users.find((u: any) => u.id === userId)
    console.log({"user": user})

    if (!user) {
        return NextResponse.json({ message: 'User not found' }, { status: 404 })
    }

    const userCategory = user.category;
    console.log({ "userCategory....": userCategory })

    const check = products.filter((products: any) => products.category === userCategory)
    console.log({ "check.....": check })

    return NextResponse.json({ user, products: check }, { status: 200 })
}

// update the user
export async function PUT(req: NextRequest, { params }: { params: { id: string } }) {
    const body = await req.json();
    const index = users.findIndex((user: any) => user.id === params.id);
    
    if (index !== -1) {
        users[index] = body;

        return NextResponse.json(body, { status: 200 });
    } else {
        return NextResponse.json({ status: 404, message: 'User not found' });
    }
}

// delete the user
export async function DELETE(req: NextRequest, { params }: { params: { id: string } }) {
    const index = users.findIndex((user: any) => user.id === params.id);

    if (index !== -1) {
        users.splice(index, 1);

        return NextResponse.json({ message: 'User deleted successfully' }, { status: 200 });
    } else {
        return NextResponse.json({ status: 404, message: 'User not found' });
    }
}