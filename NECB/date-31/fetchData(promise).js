const dataFetch = fetch("https://jsonplaceholder.typicode.com/posts")
    .then((response) => response.json())
    // .then((response) => console.log(response.json())
    .then((data) => console.log(data))
    .catch((err) => console.log(err))

dataFetch;