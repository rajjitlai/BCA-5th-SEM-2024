import { NextRequest, NextResponse } from "next/server";

interface IData{
    name: string;
    email: string;
}

const DATA:IData[] = []

export async function GET(){
    return NextResponse.json({status:200, data: DATA});
}

export async function POST(request: NextRequest){
    const body = await request.json();
    DATA.push(body);
    return NextResponse.json({status:200, data: body});
}