function Person(firstName, lastName) {
    this.firstName = firstName;
    this.lastName = lastName;

    return {
        firstName: firstName,
        lastName: lastName,
        name: this.firstName + " " + this.lastName};
}

//var Person = (function () {
//    function Person (firstName, lastName){
//        this.firstName= firstName;
//        this.lastName = lastName;
//        this.name = this.firstName + " " + this.lastName;
//    }
//
//    return Person;
//}());

var peter = new Person("Peter", "Jackson");
console.log(peter.name);
console.log(peter.firstName);
console.log(peter.lastName);
console.log("\n\n");