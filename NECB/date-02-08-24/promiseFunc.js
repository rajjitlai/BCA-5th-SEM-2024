function asyncOperation() {
    return new Promise((resolve, reject) => {
        let success = true;

        if (success) {
            resolve("Operation performed successfully")
        } else {
            reject("Operation failed")
        }
    });
}

asyncOperation().then((res) => {
    console.log(res);
}).catch((e) => {
    console.error(e);
})