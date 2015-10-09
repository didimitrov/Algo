function calcSupply(age, maxAge, food, foodPerDay) {
    var yearsLeft = maxAge - age;
    var amount = 365 * yearsLeft * foodPerDay;

    console.log(amount + 'kg of ' + food + ' would be enough until I am ' + maxAge + ' years old.');
}

calcSupply(38, 118, 'chocolate', 0.5);
calcSupply(20, 87, 'fruits', 2);
calcSupply(16, 102, 'nuts', 1.1);

