import { NextRequest, NextResponse } from "next/server";

async function UpdateUser(id: string | null) {
    return {success: true, message: `User ${id} updated`};
}

export async function PUT(req: NextRequest,{params}:{params:any}){
    try{
        // const {searchParams} = new URL(req.url)
        // const id = searchParams.get('id')
        // const name = await req.json()
        
        const id = params.id
        // console.log(id)

        
        const result = await UpdateUser(id)

        return NextResponse.json(result, {status: 200})
    }catch(error){
        console.log(error)
    }
}