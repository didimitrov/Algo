using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    public class Discipline
    {
        private string _name;
        private int _lecturesCount;
        private int _exercisesCount;

        public Discipline(string name, int exercisesCount, int lecturesCount)
        {
            this.Name = name;
            ExercisesCount = exercisesCount;
            LecturesCount = lecturesCount;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == string.Empty || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("That's not a discipline name! Invalid name input!");
                }
                _name = value;
            }
        }

        public int ExercisesCount
        {
            get { return _exercisesCount; }
            set
            {   
                if (value<0)
                {
                    throw new ArgumentException("Invalid value for number of exercises!");
                }
                _exercisesCount = value;
            }
        }

        public int LecturesCount
        {
            get { return _lecturesCount; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid value for number of lectures!");
                }
                _lecturesCount = value;
            }
        }
    }
}
