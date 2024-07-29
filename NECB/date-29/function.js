// function foo(){
//     return console.log("Hello")
// }

// foo()

// arrow function
// const foo = () => console.log("Hello")

// foo()

// function to generate Quotes from a an array
const Quotes = [
    {
        sl: 1,
        quote: "To be yourself in a world that is constantly trying to make you something else is the greatest accomplishment.",
        author: "Mark Twain"
    },
    {
        sl: 2,
        quote: "Success is not final, failure is not fatal: It is the courage to continue that counts.",
        author: "Winston Churchill",
    },
    {
        sl: 3,
        quote: "Do not go where the path may lead, go instead where there is no path and leave a trail.",
        author: "Mahatma Gandhi",
    },
    {
        sl: 4,
        quote: "The code never lies, comments sometime do.",
        author: "Unknown"
    }
]

const getQuotesFunc = (quotes) => {
    const getQuotes = quotes.map((quoteData) => {
        console.log("Sl no: ", quoteData.sl)
        console.log("Quote: ", quoteData.quote)
        console.log("Author: ", quoteData.author, "\n")
    })

    return getQuotes;
}

getQuotesFunc(Quotes)