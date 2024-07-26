let n = 3
for(let i =  2; i < n ; i++){
    if(n % i === 0){
        console.log(n + " is not a prime number");
        break;
    }
    else{
        console.log(n + " is a prime number");
    }
}

// printing the prime numbers from 2 to 20

// for (let i = 2; i <= 20; i++) {
//     let isPrime = true;
//     for (let j = 2; j <= Math.sqrt(i); j++) {
//         if (i % j === 0) {
//             isPrime = false;
//             break;
//         }
//     }
//     if (isPrime) {
//         console.log(i);
//     }
// }

