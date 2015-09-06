/*
 * 6. Write a program that removes from given 
 * sequence all numbers that occur odd number of times. 
- Example: {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}
 */

using System;
using System.Collections.Generic;

namespace _06.RemoveOddTimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new List<int> {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2};

             var ods=  ListUtils.RemoveOdd(sequence);

             foreach (var od in ods)
             {
                 Console.Write(od + " ");
             }
        }
    }
}
