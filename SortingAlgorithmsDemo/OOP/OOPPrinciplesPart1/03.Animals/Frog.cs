using System;

namespace _03.Animals
{
    public class Frog : Animal
    {
        public Frog(int age,string name, char gender) : base(name, age, gender)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Frog make sound");
        }
    }
}
