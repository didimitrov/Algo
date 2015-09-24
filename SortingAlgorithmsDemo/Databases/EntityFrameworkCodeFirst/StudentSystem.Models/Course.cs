using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace StudentSystem.Models
{
    public class Course
    {
        private ICollection<Student> _students;
        private ICollection<Homework> _homeworks; 

        public Course()
        {
            this.Homeworks = new HashSet<Homework>();
            this.Students = new HashSet<Student>();
        }

        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }

        public virtual ICollection<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return _homeworks; }
            set { _homeworks = value; }
        }
    }
}
