using System;

namespace _03.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age, 'F')
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Miauuu");
        }
    }
}
