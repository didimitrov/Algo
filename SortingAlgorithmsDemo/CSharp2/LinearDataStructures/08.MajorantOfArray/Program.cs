/*
 * 8. The majorant of an array of size N is a value that 
 * occurs in it at least N/2 + 1 times. 
 * Write a program to find the majorant of given array (if exists). 
- Example: {2, 2, 3, 3, 2, 3, 4, 3, 3} ? 3
 */

using System;

namespace _08.MajorantOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            int majoriant = ListUtils.FindMajorant(sequence);

            Console.WriteLine("The majorant is: {0}", majoriant);
        }
    }
}
