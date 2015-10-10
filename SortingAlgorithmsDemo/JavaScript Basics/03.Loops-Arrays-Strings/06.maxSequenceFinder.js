function findMaxSequence(arr) {
    var currentLength = 1;
    var maxLength = 0;
    var elementIndex = 0;

    for (var i = 0; i < arr.length - 1; i++) {
        if (arr[i] == arr[i + 1] - 1) {
            currentLength++;
        }
        else {
            if (currentLength > maxLength) {
                maxLength = currentLength;
                elementIndex = i;
            }
            currentLength = 1;
        }
    }
    for (var i = elementIndex - maxLength + 1; i <= elementIndex; i++) {
        console.log(arr[i] + " ");
    }
}

findMaxSequence([3, 2, 3, 4, 2, 2, 4]);