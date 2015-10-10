function variablesTypes(arr){
    var name = arr[0];
    var age = arr[1];
    var isMale= arr[2];
    var arrOfFavoriteFood = arr[3];

    console.log('"My name: ' + name + ' //type is ' + typeof(name));
    console.log('My age: ' + age + ' //type is ' + typeof(age));
    console.log('I am male: ' + isMale + ' //type is ' + typeof(isMale));
    console.log('My favorite foods are: ' + arrOfFavoriteFood + ' //type is ' + typeof(arrOfFavoriteFood) + '"');
}
variablesTypes(['Pesho', 22, true, ['fries', 'banana', 'cake']]);