//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

namespace _02.Max3x3SquareSum
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 4; //row
            const int m = 5; //col
            
            int[,] matrix = new int[n, m] {
                                        { 5, 8, 3, 9, 9 },
                                        { 1, 9, 6, 8, 9 },
                                        { 3, 9, 8, 7, -1000 },
                                        { 500, 2, 10, 1, -2000}
                                         };

            Console.WriteLine("Our matrix looks like:");
            Console.WriteLine();
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
