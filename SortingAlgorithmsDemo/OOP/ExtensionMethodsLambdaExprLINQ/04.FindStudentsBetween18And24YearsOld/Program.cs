using System;
using System.Linq;
using System.Security.Cryptography;

namespace _04.FindStudentsBetween18And24YearsOld
{
    class Program
    {
        static void Main(string[] args)
        {
            //04.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

            Student[] students = new Student[]
            {
                new Student("Gosho", "Petrov", 26),
                new Student("Ivan", "Georgiev", 19), //between 18 and 24
                new Student("Aleksandar", "Borisov", 24), //between 18 and 24
                new Student("Dobroslava", "Burgaska", 18), //between 18 and 24
                new Student("Dobromir", "Dobromirov", 50),
                new Student("Jorjo", "Ganchev", 16),
                new Student("Dobri", "Penchev", 22) //between 18 and 24
            };

            var result = from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var student in result)
            {
                Console.WriteLine(student.ToString());
            
            }



        }
    }
}
