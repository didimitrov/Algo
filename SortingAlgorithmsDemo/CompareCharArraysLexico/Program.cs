//Да се напише програма, която сравнява два масива от тип char лексикографски (буква по буква)
//и проверява кой от двата е по-рано в лексикографската подредба.

using System;

namespace CompareCharArraysLexico
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght for first char array: ");
            int firstLenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second lenght: ");
            int secondLenght = int.Parse(Console.ReadLine());

            char[] firstArray = new char[firstLenght];
            char[] secondArray = new char[secondLenght];

            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("Second array is first lexicographicly");
            }
            if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("First array is firs lexicographicly");
            }
            else if (firstArray.Length == secondArray.Length)
            {

                Console.WriteLine("Fill the first char array:");
                for (int i = 0; i < firstLenght; i++)
                {

                    firstArray[i] = char.Parse(Console.ReadLine());
                }

                Console.WriteLine("Fill the second char array:");
                for (int i = 0; i < secondLenght; i++)
                {

                    secondArray[i] = char.Parse(Console.ReadLine());
                }

                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine("Second array is first lexicographicly");
                        break;
                    }
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("First array is first lexicographicly");
                        break;
                    }

                }
            }
        }
    }
}
