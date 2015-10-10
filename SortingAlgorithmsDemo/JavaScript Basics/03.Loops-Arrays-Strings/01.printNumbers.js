function printNumbers(number) {
    for (var i =1; i<=number;i++) {
        if (i % 4 != 0 && i % 5 != 0) {
            console.log(i);
        }
    }
    if (parseInt(number) < 0) {
        console.log("no")
    }
}

printNumbers(20);
printNumbers(-5);
printNumbers(13);