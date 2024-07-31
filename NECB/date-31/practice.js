// synchronous
console.log("1")
console.log("2")
console.log("3")


// asynchronous
console.log("1");

setTimeout(() => 
    console.log("2")
, 5000)

console.log("3")