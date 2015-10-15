function solve(args) {
    var students = [],
        trainers = [],
        inputData = [],
        obj = {},
        resultStudents = [],
        resultTrainers = [],
        output,
        sortingConditions = args[0].split('^');

    //parse JSON string
    for (var i = 1; i < args.length; i++) {
        inputData.push(JSON.parse(args[i]));
    }

    //divide data and fill students and trainers arrays
    for (var j = 0; j < inputData.length; j++) {
        if (inputData[j].role == 'student') {
            students.push(inputData[j])
        } else if (inputData[j].role == 'trainer') {
            trainers.push(inputData[j])
        }
    }

    //sort students by: first condition firstName and second condition lastName or by level
    if (sortingConditions[0] == 'name') {
        students.sort(function (a, b) {
            if (a.firstname == b.firstname) {
                return a.lastname.localeCompare(b.lastname)
            }
            return a.firstname.localeCompare(b.firstname)
        });
    }
    else if (sortingConditions[0] == 'level') {
        students.sort(function (a, b) {
            if (a.level == b.level) {
                return a.id - b.id;
            }
            return a.level - b.level;
        })
    }

    //sort trainers by first condition number of courses and second condition lecturesPerDay
    trainers.sort(function (a, b) {
        if (a.courses.length == b.courses.length) {
            return a.lecturesPerDay - b.lecturesPerDay
        }
        return a.courses.length - b.courses.length;
    });

    //fill the resultStudents with processed data
    students.forEach(function (person) {
        var student = {
            id: person.id,
            firstname: person.firstname,
            lastname: person.lastname,
            averageGrade: avg(person.grades).toFixed(2),
            certificate: person.certificate
        };
        return resultStudents.push(student)
    });

    //fill the resultTrainers with processed data
    trainers.forEach(function (person) {
        var trainer = {
            id: person.id,
            firstname: person.firstname,
            lastname: person.lastname,
            courses: person.courses,
            lecturesPerDay: person.lecturesPerDay
        };
        return resultTrainers.push(trainer);
    });

    //function that calculate average
    function avg(arr) {
        var sum = 0;
        arr.forEach(function (element) {
            sum += Number(element)
        });
        return sum / arr.length;
    }

    //create object ouput with fields students and trainers and print it on the console as JSON string
    output = {"students": resultStudents, "trainers": resultTrainers};
    console.log(JSON.stringify(output));
}

solve(
    [
  'level^courses',
  '{"id":0,"firstname":"Angel","lastname":"Ivanov","town":"Plovdiv","role":"student","grades":["5.89"],"level":2,"certificate":false}',
  '{"id":1,"firstname":"Mitko","lastname":"Nakova","town":"Dimitrovgrad","role":"trainer","courses":["PHP","Unity Basics"],"lecturesPerDay":6}',
  '{"id":2,"firstname":"Bobi","lastname":"Georgiev","town":"Varna","role":"student","grades":["5.59","3.50","4.54","5.05","3.45"],"level":4,"certificate":false}',
  '{"id":3,"firstname":"Ivan","lastname":"Ivanova","town":"Vidin","role":"trainer","courses":["JS","Java","JS OOP","Database","OOP","C#"],"lecturesPerDay":7}',
  '{"id":4,"firstname":"Mitko","lastname":"Petrova","town":"Sofia","role":"trainer","courses":["Database","JS Apps","Java"],"lecturesPerDay":2}'
    ]);