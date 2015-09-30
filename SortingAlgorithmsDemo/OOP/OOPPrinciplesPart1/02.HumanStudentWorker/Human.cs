using System;

namespace _02.HumanStudentWorker
{
    public abstract class Human
    {
       protected Human(string firstName, string lastName)
       {
           LastName = lastName;
           FirstName = firstName;
       }

       public string FirstName { get; private set; }
       public string LastName { get; private set; }

       public override string ToString()
       {
           return String.Format("{0} {1}", this.FirstName, this.LastName);
       }
    }
}
