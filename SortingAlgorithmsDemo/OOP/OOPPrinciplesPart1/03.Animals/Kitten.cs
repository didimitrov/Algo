using System;

namespace _03.Animals
{
    class Kitten:Animal
    {
        public Kitten(int age, string name)
            : base(name, age, 'F')
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Kittens make sound");
        }
    }
}
