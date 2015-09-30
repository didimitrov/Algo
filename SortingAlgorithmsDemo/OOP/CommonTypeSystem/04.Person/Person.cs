using System;
using System.Text;
        
namespace _04.Person
{
    public class Person
    {
        private int? _age;
        private string _name;

        public Person(string name, int? age):this(name)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == string.Empty || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception();
                }
                _name = value;
            }
        }

        public int? Age
        {
            get { return _age; }
            set
            {
                if (value <= 0 || value >= 120)
                {
                    throw new ArgumentOutOfRangeException("Age of person can't be negative or bigger than 120!");
                }
                _age = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("Name: " + this.Name);
            if (this.Age != null)
            {
                result.Append("Age: " + this.Age);
            }
            else
            {
                result.Append("Age: no information");
            }
            return result.ToString();
        }

    }
}