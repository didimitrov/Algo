using System;
using System.Linq;

namespace _04.MaximalSequenceOfEqualElements
{
    //Write a program that finds the maximal sequence of equal elements in an array.

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght of the sequence.");
            var seqL = int.Parse(Console.ReadLine());
            var sequence = new int[seqL];

            var currentLenght = 1;
            var bestLenght = 0;
            var element = 0;

            Console.WriteLine("Enter number for the sequence");
            for (int i = 0; i < seqL; i++)
            {
                Console.WriteLine("Element[{0}]", i);
                sequence[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    currentLenght++;
                }
                else
                {
                    if (bestLenght < currentLenght)
                    {
                        bestLenght = currentLenght;
                        element = sequence[i];
                    }
                    currentLenght = 1;
                }
            }

            Console.WriteLine("The longest sequence if form {0} elements of type {1} .", bestLenght, element);

            //Linq
            //int[] max = sequence.Select((n, i) => new {Value = n, Index = i})
            //    .OrderBy(s => s.Value)
            //    .Select((o, i) => new {Value = o.Value, Diff = i - o.Index})
            //    .GroupBy(s => new {s.Value, s.Diff})
            //    .OrderByDescending(g => g.Count())
            //    .First()
            //    .Select(f => f.Value)
            //    .ToArray();
        }
    }
}
