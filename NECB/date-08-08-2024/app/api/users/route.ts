import { addPosts, getPosts } from "@/app/lib/data"
import { NextResponse } from "next/server"

export const GET = async (req: Request, res: Response) => {
    try {
        const posts = getPosts()
        return NextResponse.json(posts)
    } catch (err) {
        return NextResponse.json({ message: "Error", err }.err, { status: 500 })
    }
}

export const POST = async (req: Request, res: Response) => {
    const { title, desc } = await req.json()
    
    try {
        const post = { title, desc, date: new Date(), id: Date.now().toString() };
        addPosts(post);
        return NextResponse.json(post)
    } catch (err) {
        return NextResponse.json({ message: "Error", err }.err, { status: 500 })
    }
}
