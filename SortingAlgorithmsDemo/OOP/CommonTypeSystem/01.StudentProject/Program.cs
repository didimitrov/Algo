using System;
using System.Text;

namespace _01.StudentProject
{
    //01.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail,
    //course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
    //Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
    class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Marin", "Petrov", "Petrov", 2, "1244456", "J.K. Lulin", "0899123123", "marin@abv.bg", SpecialtyType.AppliedMathematics, UniversityType.SofiaUniversity, FacultyType.MathematicsAndInformatics);

            Student secondStudent = new Student("Georgi", "Marinov", "Mitev", 2, "1247856", "J.K. Mladost", "0899987987", "Georgi@abv.bg", SpecialtyType.Medicine, UniversityType.MedicalUniversityOfSofia, FacultyType.Biology);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(firstStudent);
            Console.WriteLine();
            Console.ResetColor();

            Student clonedStudent = firstStudent.Clone();
            Console.WriteLine(clonedStudent);
            Console.WriteLine();

            Console.WriteLine(firstStudent.CompareTo(secondStudent));
            Console.WriteLine("(firstStudent == secondStudent) -> {0}", firstStudent == secondStudent);
            Console.WriteLine("(firstStudent != secondStudent) -> {0}", firstStudent != secondStudent);
            Console.WriteLine("(firstStudent == clonedStudent) -> {0}", firstStudent == clonedStudent);

            Console.WriteLine();
            Console.WriteLine("Is first equal to second -> {0}", firstStudent.Equals(secondStudent));
            Console.WriteLine("Is first equal to cloned -> {0}", firstStudent.Equals(clonedStudent));
        }
    }
}
