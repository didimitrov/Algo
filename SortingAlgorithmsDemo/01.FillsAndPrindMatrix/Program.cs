/*
 * Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)﻿
 */

using System;

namespace _01.FillsAndPrindMatrix
{
    internal class Program
    {
        private static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of cols: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows,cols];

            int someNumber = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = someNumber;
                    someNumber++;
                }
            }

            PrintMatrix(matrix);
        }
    }
}

