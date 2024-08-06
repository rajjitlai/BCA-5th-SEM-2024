import { NextRequest, NextResponse } from "next/server";

async function UpdateUser(id: string | null, data: any) {
    return {success: true, message: `User ${id} updated`, data };
}

export async function PUT(req: NextRequest){
    try{
        const {searchParams} = new URL(req.url)
        const id = searchParams.get('id')

        const json = await req.json()
        const newData = json.data;

        const result = await UpdateUser(id, newData)

        return NextResponse.json(result, {status: 200})
    }catch(error){
        console.log(error)
    }
}