using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace _01.School
{
    public class Class
    {
        private ICollection<Teacher> _teachers;
        private ICollection<Student> _students;
        private string _identifire;

       

        public Class(string identifire)
        {
            this.Identifire = identifire;
            this.Students = new HashSet<Student>();
            _teachers = new HashSet<Teacher>();
        }

        public string Identifire
        {
            get { return _identifire; }
            set
            {
                _identifire = value;
            }
        }

        public ICollection<Student> Students
        {
            get { return _students; }
           private set { _students = value; }
        }

        public void AddStudent(Student student)
        {
            bool isInThisClass = this.Students.Count(x => x.Fn == student.Fn) == 0;

            if (!isInThisClass)
            {
                this.Students.Add(student);
            }
            Console.WriteLine("There is a student in class with this class number.");
        }

        public void AddTeacher(Teacher teacher)
        {
            bool isInThisClass = this._teachers.Count(x => x.Name == teacher.Name) == 0;

            if (!isInThisClass)
            {
                this._teachers.Add(teacher);
            }
            else
            {
                Console.WriteLine("This teacher teaches this class.");
            }
        }
       
    
    }
}
