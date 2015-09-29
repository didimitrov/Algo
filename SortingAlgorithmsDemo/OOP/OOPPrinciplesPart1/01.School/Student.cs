using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    public class Student : Person
    {
        private int _fn;

        public Student(string name, int fn) : base(name)
        {
            this.Name = name;
            Fn = fn;
        }

     //   public string Name { get; set; }

        public int Fn
        {
            get { return _fn; }
            set
            {
                if (value>0)
                {
                    _fn = value;
                    
                }
                throw  new Exception();
            }
        }
    }
}
