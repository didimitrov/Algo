function clone(obj) {
    return JSON.parse(JSON.stringify(obj));
}

function compareObjects(obj, cloneObj) {
    console.log('a == b --> ' + (obj == cloneObj));
}

var a = {name: 'Pesho', age: 21};
var b = clone(a); // a deep copy
compareObjects(a, b);

a = {name: 'Pesho', age: 21};
b = a; // not a deep copy
compareObjects(a, b);