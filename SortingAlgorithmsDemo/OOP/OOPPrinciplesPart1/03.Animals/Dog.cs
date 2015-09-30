using System;

namespace _03.Animals
{
    class Dog:Animal
    {
        public Dog(int age, string name, char gender)
            : base(name, age, gender)
        {
        }

        public override void Sound()
        {
          Console.WriteLine("Bau bau");
        }
    }
}
