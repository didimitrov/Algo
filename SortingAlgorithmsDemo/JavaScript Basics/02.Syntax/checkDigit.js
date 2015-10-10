function checkDigit(numb) {
    var thirdDigit = parseInt(numb.toString()[numb.toString().length - 3]);

    if (thirdDigit == 3) {
        console.log("true")
    }else {
        console.log("false")
    }
}

checkDigit(1234);
checkDigit(25368);
checkDigit(123456);