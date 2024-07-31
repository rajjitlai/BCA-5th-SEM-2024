function total(){
    return console.log(2 + 2)
}

const sum = (check) => {
    check();
}

sum(total);