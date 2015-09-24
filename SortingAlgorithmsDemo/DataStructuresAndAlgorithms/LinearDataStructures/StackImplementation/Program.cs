using System;
using System.Collections.Generic;


namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new CustomStack<int>();

            var actual = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                myStack.Push(i);
            }

            foreach (var item in myStack)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine(myStack.Count);
        }
    }
}
