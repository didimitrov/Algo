using System;
using System.Collections.Generic;
using System.Linq;

namespace SortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine().Split().ToList();
            //var sorted = input.OrderBy(x => x);
            //Console.WriteLine(String.Join(" ",sorted));
          
            var input = Console.ReadLine();
            var words = new List<string>();

            if (input != null) words = input.Split(' ').ToList();
            words.Sort();

            Console.WriteLine(String.Join(" ", words));
        }
    }
}
