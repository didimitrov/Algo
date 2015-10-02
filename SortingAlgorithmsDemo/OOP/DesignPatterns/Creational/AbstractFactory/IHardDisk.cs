using System;

namespace AbstractFactory
{
    public interface IHardDisk
    {
        void StoreData();
    }

    public class ExpensiveHdd:IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Data will take less time to store");
        }
    }

    public class CheepHdd:IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Data will take more time to store");
        }
    }
}
