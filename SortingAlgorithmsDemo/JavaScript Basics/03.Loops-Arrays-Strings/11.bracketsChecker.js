function checkBrackets(str) {
    var openBracket = 0;
    var closeBracket = 0;

    for (var i = 0; i < str.length; i++) {
        if (str[i] == '(') {
            openBracket++;
        }
        if (str[i] == ')') {
            closeBracket++;
        }
    }
    if (openBracket == closeBracket) {
        return 'correct'
    }
    return 'incorrect'
}

console.log(checkBrackets('( ( a + b ) / 5 – d )'));
console.log(checkBrackets(') ( a + b ) )'));
console.log(checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));