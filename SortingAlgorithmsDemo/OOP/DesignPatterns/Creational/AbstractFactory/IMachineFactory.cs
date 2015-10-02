namespace AbstractFactory
{
    public interface IMachineFactory
    {
        IProcessor GetProcessor();
        IHardDisk GetHardDisk();
        IMonitor GetMonitor();
    }

    public class HighBudgetMachine:IMachineFactory
    {
        public IProcessor GetProcessor()
        {
            return new ExpensiveProcessor();
        }

        public IHardDisk GetHardDisk()
        {
           return new ExpensiveHdd();
        }

        public IMonitor GetMonitor()
        {
            return new HighResolutionMonitor();
        }
    }

    public class LowBudgetMachine:IMachineFactory
    {
        public IProcessor GetProcessor()
        {
            return new CheepProcessor();
        }

        public IHardDisk GetHardDisk()
        {
            return new CheepHdd();
        }

        public IMonitor GetMonitor()
        {
            return new LowResolutionMonitor();
        }
    }
}
