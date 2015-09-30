using System;
using System.Linq;

namespace _03.Animals
{
    public abstract class Animal : ISound
    {
        private string _name;
        private int _age;
        private char _gender;

        protected Animal(string name, int age, char gender)
        {
            Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _age = value;
            }
        }

        public char Gender
        {
            get { return _gender; }
            set
            {
                if (value != 'f' && value != 'm' && value != 'F' && value != 'M')
                {
                    throw new ArgumentException("Invalid gender input!");
                }
                _gender = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value==string.Empty || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid animal name! Name can not be null, whitespace or empty!");
                }
                _name = value;
            }
        }

        public abstract void Sound();

        public static double AvgAge(Animal[] animals)
        {
           // var avgAge = animals.Average(x => x.Age);

            var age = 0.0;
            foreach (var animal in animals)
            {
                age = age + animal.Age;
            }
            var avgAge = age/animals.Length;
            return avgAge;
        }

    }
}
