function findLargestBySumOfDigits(arr) {

    var currentSum = 0;
    var bestSum = 0;
    var bestElement;

    for (var i = 0; i < arr.length; i++) {

        if (typeof(arr[i]) != 'number') {
            return undefined;
        }

        var numberAsString = arr[i].toString().replace(/-/, '');

        for (var j = 0; j < numberAsString.length; j++) {
            currentSum += parseInt(numberAsString[j]);

            if (currentSum > bestSum) {
                bestSum = currentSum;
                bestElement = arr[i];
            }
        }

        currentSum = 0;
    }
    console.log(bestElement)
}

findLargestBySumOfDigits([5, 10, 15, 111]);
findLargestBySumOfDigits([33, 44, -99, 0, 20]);
findLargestBySumOfDigits(['hello']);





//function findLargestBySumOfDigits() {
//    "use strict";
//
//    var numbers = [];
//    var n = arguments.length;
//    var sum = 0;
//    var tempSum = 0;
//    var position = 0;
//
//    This loop push all the arguments in an array (remember, variable number of arguments as input!
//    for (var i = 0; i < n; i++) {
//        numbers.push(arguments[i]);
//    }
//    if (numbers == '') {
//        console.log('undefined');
//        return;
//    }
//
//    This loop checks if there is any argument that is not a number.
//    for (var i = 0; i < n; i++) {
//        var integer = parseFloat(numbers[i]);
//        var checkFloating = parseFloat(numbers[i]);
//        var roundedNumber = Math.floor(checkFloating);
//
//        if (isNaN(integer) || checkFloating !== roundedNumber) {
//            console.log('undefined');
//            return;
//        }
//    }