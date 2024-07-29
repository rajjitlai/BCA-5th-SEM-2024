const bike = [
    {
        brand: "Yezdi",
        model: "Roadster"
    },
    {
        brand: "Yamaha",
        model: "R9"
    },
    {
        brand: "Kawasaki",
        model: "ZX10R"
    }
]


function one(bikeOne) {
    bikeOne.map((data) => {
        data.model == "R9" && console.log(data.brand) 
    })
}


// function one(bikeOne) {
//     bikeOne.map((data) => {
//         data.model == "R9" ? console.log(data.brand) : 
//         console.log("Bike not found")
//     })
// }

// function one(bikeOne) {
//     bikeOne.map((data) => {
//         const {model, brand} = data
//         model == "R9" && console.log(brand) 
//     })
// }

one(bike)