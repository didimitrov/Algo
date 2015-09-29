using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _03.FindStudentsWithFirstNameBeforeLast
{
    class Program
    {
        static void Main()
        {
//03.Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.

            var students = new List<Student>
            {
                new Student("Gosho", "Petrov"),
                new Student("Ivan", "Georgiev"),
                new Student("Aleksandar", "Borisov"),
                new Student("Dobroslava", "Burgaska"),
                new Student("Dobromir", "Dobromirov")
            };
            var result = from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;
            foreach (var student in result)
            {
                Console.WriteLine("First name: {0}, Last name: {1}", student.FirstName, student.LastName);
              
            }



        }
    }
}
