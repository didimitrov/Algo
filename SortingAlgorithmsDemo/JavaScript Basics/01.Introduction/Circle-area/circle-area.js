function calculateCircleArea(r) {
    return r * r * Math.PI
}

document.getElementById("first").innerHTML = calculateCircleArea(7);
document.getElementById("second").innerHTML = calculateCircleArea(1.5);
document.getElementById("third").innerHTML = calculateCircleArea(15);
