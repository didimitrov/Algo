using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Person :Comment
    {
        private string _name;

        public Person(string name)
        {
            this.Name = name;
           // this.Comments = new HashSet<Comment>();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value==string.Empty || string.IsNullOrWhiteSpace(value))
                {
                    throw  new ArgumentNullException();
                }
                _name = value;
            }
        }

       // public ICollection<Comment> Comments { get; set; }

    }
}
