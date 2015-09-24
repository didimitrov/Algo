using System;
using System.Linq.Expressions;
using DataLibrary;
using StudentSystem.Models;

namespace StudentSystem.Client
{
    class Program
    {
        private static void PrintStudents(ApplicationDbContext context)
        {
            Console.WriteLine("Srudents: ");

            foreach (var student in context.Students.Include("Courses"))
            {
                 Console.WriteLine(" - {0} -> present in {1} course(s).", student.Name, student.Courses.Count);
            }
        }

        private static void PrintCourses(ApplicationDbContext context)
        {
            Console.WriteLine("\nCourses: ");

            foreach (var course in context.Courses.Include("Homeworks"))
            {
                Console.WriteLine(" - {0} -> has {1} homework(s).", course.Description, course.Homeworks.Count);
            }
        }

        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            db.Database.Initialize(true);
            PrintStudents(db);


            var rnd = new Random();
            using (db)
            {
                for (int i = 0; i < 20; i++)
                {
                    var newStudent = new Student()
                    {
                        Name = "Mitko" + i,
                        StdentNumber = rnd.Next(100000, 999999)
                    };

                    db.Students.Add(newStudent);
                }
                db.SaveChanges();
            }

        }
    }
}
