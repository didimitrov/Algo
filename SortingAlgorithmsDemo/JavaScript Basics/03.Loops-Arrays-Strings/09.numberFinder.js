function numberFinder(arr) {
    var bestLength = 0;
    var currentLength = 1;
    var bestNumber;

    for (var i = 0; i < arr.length; i++) {
        for (var j = i + 1; j < arr.length; j++) {
            if (arr[i] == arr[j]) {
                currentLength++;
            }
            if (currentLength > bestLength) {
                bestLength = currentLength;
                bestNumber = arr[i];
            }
        }
        currentLength = 1;
    }
    console.log("Number: " + bestNumber + " - (" + bestLength + " times)")
}
numberFinder([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]);