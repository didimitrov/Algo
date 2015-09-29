using System.Collections.Generic;

namespace _01.School
{
    public  class School
    {
        private ICollection<Class> _classes;
        private ICollection<Student> _students;
        private ICollection<Teacher> _teachers; 
       
        public School()
        {
            this.Teachers = new HashSet<Teacher>();
            Students = new HashSet<Student>();
            this.Classes = new HashSet<Class>();
        }

        public ICollection<Class> Classes
        {
            get { return _classes; }
           private set { _classes = value; }
        }

        public ICollection<Student> Students
        {
            get { return _students; }
            private set { _students = value; }
        }

        public ICollection<Teacher> Teachers
        {
            get { return _teachers; }
            set { _teachers = value; }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }
    }
}
