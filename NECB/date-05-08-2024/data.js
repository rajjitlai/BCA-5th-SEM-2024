const data = [
    {
    name: 'John Doe',
    age: 30,
    address: "California, USA"
    },
    {
        name: 'Jane Doe',
        age: 28,
        address: "New York, USA"
    }
]

let data2Json = JSON.stringify(data);
const jsonData = require('./data.json')

let json2Data = JSON.stringify(jsonData)

// without stringify
// console.log({"data...": jsonData})

const data2Object = JSON.parse(data2Json)

// console.log(data2Json)
// console.log(jsonData)
// console.log(json2Data)

// console.log(data2Object)

// console.log(data)

// mapping objects
data.map((key) => {
    // console.log(key)
    if(key.name == "John Doe"){
        console.log(key)
    }
})
