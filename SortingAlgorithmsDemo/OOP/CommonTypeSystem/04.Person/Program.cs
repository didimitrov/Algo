using System;

namespace _04.Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Petar Dimitrov", 15);
            Person mariq = new Person("Mariq Petrova", null);
            Person grigor = new Person("Grigor Vasilev");

            Console.WriteLine(pesho);
            Console.WriteLine();

            Console.WriteLine(mariq);
            Console.WriteLine();

            Console.WriteLine(grigor);
            Console.WriteLine();
        }
    }
}
