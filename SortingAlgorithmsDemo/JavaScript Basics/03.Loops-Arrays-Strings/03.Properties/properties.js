function displayProperties() {
    var properties = [];

    for (var property in document) {
        properties.push(property);
    }

    properties.sort();

    properties.forEach(function (element) {
        console.log(element);
    });

    document.getElementById('message').innerHTML = 'Check the result in the console (F12)'
}