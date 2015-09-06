using System;
using System.Collections.Generic;

namespace TestLinearDataStructures
{
    class Program
    {

        static List<int> Union(IEnumerable<int> firstList, IEnumerable<int> secondList)
        {
            var union = new List<int>();

            union.AddRange(firstList);

            foreach (var i in secondList)
            {
                if (!union.Contains(i))
                {
                    union.Add(i);
                }
            }
            return union;

            
        }

       

        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Message One");
            queue.Enqueue("Message Two");
            queue.Enqueue("Message Three");
            queue.Enqueue("Message Four");
            while (queue.Count > 0)
            {
                string msg = queue.Dequeue();
                Console.WriteLine(msg);
            }
        }
    }
}
