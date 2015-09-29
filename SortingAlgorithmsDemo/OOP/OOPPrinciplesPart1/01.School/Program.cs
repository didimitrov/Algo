using System;
using System.Collections.Generic;

namespace _01.School
{
    class Program
    {
        static void Main(string[] args)
        {
            School firstClass = new School();

            Teacher firstTeacher = new Teacher("Ivan");
            firstClass.AddTeacher(firstTeacher);

            Teacher secondTeacher = new Teacher("Stoian");
            firstClass.AddTeacher(secondTeacher);

            Teacher thirdTeacher = new Teacher("Dragan");
            firstClass.AddTeacher(thirdTeacher);
           

          

            foreach (var teacher in firstClass.Teachers)
            {
                teacher.Name = "test";
            }
        }
    }
}
