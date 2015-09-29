using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    public class Teacher : Person
    {
        private readonly ICollection<Discipline> _disciplines;

        public Teacher(string name) : base(name)
        {
            this.Name = name;
            _disciplines = new HashSet<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            bool isAllreadyTeached = this._disciplines.Count(x => x.Name == discipline.Name) == 0;

            if (!isAllreadyTeached)
            {
                this._disciplines.Add(discipline);
            }
        }
       
    }
}
