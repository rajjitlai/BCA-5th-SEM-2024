type POST = {
    id: string,
    title: string,
    desc: string,
    date: string,
}

let posts:POST[] = []

export const getPosts = () => posts

export const addPosts = (post: POST) => {
    posts.push(post) 
}

export const updatePost = (id: string, title: string, desc:string) => {
    const post = posts.find(post => post.id === id)

    if(post){
        post.title = title
        post.desc = desc
    }else{
        throw new Error("No posts found")
    }
}

export const getPostById = (id: string) => {
    return posts.find(post => post.id === id)
}

export const deletePost = (id:string) => {
    posts = posts.filter(post => post.id!== id)
}