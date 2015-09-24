using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        private ICollection<Course> _courses;
        private ICollection<Homework> _homeworks;

        public Student()
        {
            this.Courses = new HashSet<Course>();
            this.Homeworks = new HashSet<Homework>();
        }


        [Key]
        public int StudentId { get; set; }

        [MinLength(5)]
        [MaxLength(100)]
        public string Name { get; set; }

        public int StdentNumber { get; set; }

        

        public virtual ICollection<Homework> Homeworks
        {
            get { return _homeworks; }
            set { _homeworks = value; }
        }

        public virtual ICollection<Course> Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }
    }
}
