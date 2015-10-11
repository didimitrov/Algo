function reverseString(str) {
    var result = "";
    for (var i = str.length - 1; i >= 0; i--) {
        result += str[i];
    }
    console.log(result)
}

reverseString('softUni');

//Alternative
//function reverseString(str) {
//    return str.split('').reverse().join('');
//}