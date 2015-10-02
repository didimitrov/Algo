using System;

namespace AbstractFactory
{
    public interface IProcessor
    {
        void PerformOperation();
    }

    public class ExpensiveProcessor:IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Operation will perform Quickly");
        }
    }

    public class CheepProcessor:IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Operation will perform Slowly");
        }
    }
}
