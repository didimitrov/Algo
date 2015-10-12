var bigInt = require("big-integer");

function sumTwoHugeNumbers(args) {
    var first = new bigInt(args[0]);
    var second = new bigInt(args[1]);
    console.log(first.plus(second).value);
}

sumTwoHugeNumbers(['155', '65']);
sumTwoHugeNumbers(['123456789', '123456789']);
sumTwoHugeNumbers(['887987345974539', '4582796427862587']);