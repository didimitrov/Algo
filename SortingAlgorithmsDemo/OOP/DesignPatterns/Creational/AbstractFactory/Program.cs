namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IMachineFactory factory = new HighBudgetMachine();// Or new LowBudgetMachine();

            ComputerShop shop = new ComputerShop(factory);

            shop.AssembleMachine();
        }
    }
}
