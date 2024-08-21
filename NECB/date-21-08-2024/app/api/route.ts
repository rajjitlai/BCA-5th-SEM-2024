import { NextResponse } from "next/server";

import { PrismaClient } from "@prisma/client";

const prisma = new PrismaClient();

export async function GET(req:NextResponse){
    const user = await prisma.user.findMany()
    console.log({'user': user})

    return NextResponse.json(user, {status: 200})
}