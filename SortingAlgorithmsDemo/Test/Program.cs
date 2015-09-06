using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

namespace Test
{
    internal class Program
    {
        static long Fib(int n)
        {
            if (n<=2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }

        static long Factorial(int n)
        {
            if (n==0)
            {
                return 1;
            }
            return n*Factorial(n - 1);
        }

        static long FactorialForLoop(int n)
        {
            int result = 1;
            for (int i = 1; i < n; i++)
            {
                result = result*i;
            }
        }
        private static void Main(string[] args)
        {
            
            //F1 = F2 = 1
            //Fi = Fi-1 + Fi-2 (за i > 2)
        }
    }
}



