const Data = [
    {
        id: 1,
        name: 'John',
        age: 25
    },
    {
        id: 2,
        name: 'Jane',
        age: 30
    },
]

const result = Data.map((item, idx) => {
    console.log({ "item...": item, "index...": idx });
});

// Output:
/*
{ 'item...': { id: 1, name: 'John', age: 25 }, 'index...': 0 }
{ 'item...': { id: 2, name: 'Jane', age: 30 }, 'index...': 1 }
*/

// current, index, array