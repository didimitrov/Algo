function printArgsInfo(){

    for (var i in arguments) {
        var currentElement = arguments[i];
        var currentElementType = typeof currentElement;

        if (Array.isArray(currentElement)) {
            currentElementType = "array";
        }

        console.log(currentElement + " (" + currentElementType + ")");
    }
    console.log()
}
printArgsInfo(2, 3, 2.5, -110.5564, false);
printArgsInfo(null, undefined, "", 0, [], {});
printArgsInfo([1, 2], ["string", "array"], ["single value"]);
printArgsInfo("some string", [1, 2], ["string", "array"], ["mixed", 2, false, "array"], { name: "Peter", age: 20 });
printArgsInfo([[1, [2, [3, [4, 5]]]], ["string", "array"]]);

printArgsInfo.call();
printArgsInfo.call(this, 2, ["asd"], undefined);

printArgsInfo.apply();
printArgsInfo.apply(this, [2, ["asd"], undefined])