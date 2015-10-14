function solve(input) {
    var matrix = [];

    for (var i = 0; i < input.length; i++) {
        matrix.push(input[i].split(''));
        input[i] = input[i].toLowerCase();
    }

    for (var row = 0; row < input.length - 2; row++) {
        for (var col = 0; col < input[row].length; col++) {
            var a = input[row][col];
            var b = input[row + 1][col - 1];
            var c = input[row + 1][col];
            var d = input[row + 1][col + 1];
            var e = input[row + 2][col];

            if (a == b && b == c && c == d && d == e) {
                matrix[row][col] = '';
                matrix[row + 1][col - 1] = '';
                matrix[row + 1][col] = '';
                matrix[row + 1][col + 1] = '';
                matrix[row + 2][col] = '';
            }
        }
    }

    matrix = matrix.join("\n").replace(/\,/g, '');
    console.log(matrix);
}

//var checkValues = [
//    [
//        'ab**l5',
//        'bBb*555',
//        'absh*5',
//        'ttHHH',
//        'ttth'
//    ],
//    [
//        '888**t*',
//        '8888ttt',
//        '888ttt<<',
//        '*8*0t>>hi'
//    ],
//    [
//        '@s@a@p@una',
//        'p@@@@@@@@dna',
//        '@6@t@*@*ego',
//        'vdig*****ne6',
//        'li??^*^*'
//    ]
//];
//
//for (var i in checkValues) {
//    solve(checkValues[i]);
//}