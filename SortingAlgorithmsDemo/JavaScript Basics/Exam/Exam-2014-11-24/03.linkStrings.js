function solve(args) {
    var result = {};

    for (var i = 0; i < args.length; i++) {
        var currentLine = args[i]

        if (currentLine.indexOf("http") > -1) {
            var del = currentLine.indexOf("?");
            currentLine = currentLine.slice(del + 1, currentLine.length);
        }

        var queries = currentLine.split('&');

        for (var j = 0; j < queries.length; j++) {
            var currQuery = queries[j];

            currQuery = currQuery.replace(/%20|\+/g, ' ').split(/\s*=\s*/);

            var key = currQuery[0];
            var value = currQuery[1];
            value = value.replace(/\s+/g, ' ').trim();

            if (!result[key]) {
                result[key] = [];
            }

            result[key].push(value);
        }

        var keys = Object.keys(result);

        var output = '';

        for (var j = 0; j < keys.length; j++) {
            var keyStr = keys[j] + '=';
            var values = getValues(keys[j], result);
            output += keyStr + values;
            delete result[keys[j]]
        }
        console.log(output)

    }

    function getValues(key, obj) {
        var out = "[";

        for (var i = 0; i < obj[key].length; i++) {
            out += obj[key][i] + ',';
        }
        out = out.substring(0, out.length - 1) + ']';
        return out;
    }

    console.log(keys)
}

solve([
    'foo=%20foo&value=+val&foo+=5+%20+203',
    'foo=poo%20&value=valley&dog=wow+',
    'url=https://softuni.bg/trainings/coursesinstances/details/1070',
    'https://softuni.bg/trainings?trainer=nakov&course=oop&course=php'
]);