using System;

namespace AbstractFactory
{
    public interface IMonitor
    {
        void Display();
    }

    public class HighResolutionMonitor:IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Picture will be with best quality");
        }
    }

    public class LowResolutionMonitor:IMonitor
    {
        public void Display()
        {
            Console.WriteLine("Picture will be with low quality");
        }
    }
}
