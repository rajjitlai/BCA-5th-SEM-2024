import { NextRequest, NextResponse } from "next/server";

const users = require('../users.json')
const products = require('../../products/products.json')

// const data = [
//     {
//         id: '1',
//         name: 'jack',
//         department: 'cse'
//     },
//     {
//         id: '2',
//         name: 'jill',
//         department: 'eee'
//     }
// ]

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