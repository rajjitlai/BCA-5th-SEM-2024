import { NextRequest, NextResponse } from "next/server"

const data = require('../users/users.json')

export function GET() {
    return NextResponse.json(data, { status: 200 });
}

export async function POST(req: NextRequest) {
    const body = await req.json();
    data.push(body);
    console.log(body);
    return NextResponse.json(body, { status: 200 });
}