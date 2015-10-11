function findNthDigit(arr) {
    var n = arr[0];
    var num = arr[1].toString();
    num = num.replace(/\D+/g, '');

    var digit = num[num.length - n];

    if (digit == undefined) {
        digit = 'The number doesn’t have 6 digits';
    }
    console.log(digit)
}
findNthDigit([1, 6]);
findNthDigit([6, 923456]);
findNthDigit([3, 1451.78]);
findNthDigit([6, 888.88]);