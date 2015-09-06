/*
 * 5. Write a program that removes from given
 * sequence all negative numbers.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> sequence = new List<int>()  {1, 2, 3, -12, 3, -12};

            
           ListUtils.Print(ListUtils.RemoveNegativeNums(sequence));

           //Linq
            //sequence.Where(x => x > 0);

            // Using LINQ
            //var noneNegativeList =
            //    from element in sequence
            //    where element > 0
            //    select element;
            
        }
    }
}
