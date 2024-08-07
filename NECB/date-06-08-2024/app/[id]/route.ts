import { NextRequest, NextResponse } from "next/server";

async function UpdateUser(id: string | null, data: any) {
    return {success: true, message: `User ${id} updated`, data };
}

export async function PUT(req: NextRequest,{params}:{params:any}){
    try{
        // const {searchParams} = new URL(req.url)
        // const id = searchParams.get('id')
        
        const id = params.id
        // console.log(id)

        const name = await req.json()
        
        const result = await UpdateUser(id, name)

        return NextResponse.json(result, {status: 200})
    }catch(error){
        console.log(error)
    }
}