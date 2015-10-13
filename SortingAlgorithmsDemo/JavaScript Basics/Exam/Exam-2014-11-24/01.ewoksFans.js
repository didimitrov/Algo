function count(args) {
    var fans = [];
    var haters = [];

    for (var i = 0; i < args.length; i++) {
        var splitedDate = args[i].split('.');
        var date = new Date(splitedDate[2] + '-' + splitedDate[1] + '-' + splitedDate[0]);

        if (date > new Date('1973-05-25') && date < new Date('2015-01-01')) {
            fans.push(date);
        }
        if (date < new Date('1973-05-25') && date > new Date('1900-01-01')) {
            haters.push(date);
        }

        haters.sort(function (a, b) {
            return a - b
        });
        fans.sort(function (a, b) {
            return a - b
        });
    }
    console.log("Biggest hater is: " + haters[haters.length - 1]);
    console.log("Biggest fan is: " + fans[0]);
}

var checkValues = [
    [
        '22.03.2014',
        '17.05.1933',
        '10.10.1954'
    ],
    [
        '22.03.2000'
    ],
    [
        '22.03.1700',
        '01.07.2020'
    ]
];

for (var i in checkValues) {
    count(checkValues[i]);
}