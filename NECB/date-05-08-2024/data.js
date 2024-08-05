const data = {
    name: 'John Doe',
    age: 30,
    address: {
        street: '123 Main St',
        city: 'New York',
        state: 'NY'
    }
}

let data2Json = JSON.stringify(data);
const jsonData = require('./data.json')

let json2Data = JSON.stringify(jsonData)

// without stringify
console.log({"data...": jsonData})

const data2Object = JSON.parse(data2Json)

console.log(data2Json)
console.log(jsonData)
console.log(json2Data)

console.log(data2Object)