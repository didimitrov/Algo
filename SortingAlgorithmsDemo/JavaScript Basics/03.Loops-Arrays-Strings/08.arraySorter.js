function arraySorter(arr) {
    var minIndex;

    for (var i = 0; i < arr.length; i++) {
        minIndex = i;
        for (var j = i + 1; j < arr.length; j++) {
            if (arr[j] < arr[minIndex]) {
                minIndex = j;
            }
        }
        var temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;

    }
    console.log(arr)
}

//arraySorter([5, 4, 3, 2, 1]);
arraySorter([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]);