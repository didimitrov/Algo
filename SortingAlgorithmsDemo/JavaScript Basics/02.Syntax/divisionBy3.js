function divisionBy3(number) {
    var sum = 0;
    var length = number.toString().length;

    for (var i = 0; i <= length - 1; i++) {
        sum += parseInt(number.toString()[i])
    }

    if (sum % 3 == 0) {
        console.log("Is divisible by 3")
    } else {
        console.log("Is not divisible by 3")
    }
}
divisionBy3(188);