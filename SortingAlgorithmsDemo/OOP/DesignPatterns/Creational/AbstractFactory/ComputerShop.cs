namespace AbstractFactory
{
   public  class ComputerShop
   {
       private  IMachineFactory _factory;

       public ComputerShop(IMachineFactory factory)
       {
           this.Factory = factory;
       }

       public IMachineFactory Factory
       {
           get { return _factory; }
           set { _factory = value; }
       }

       public void AssembleMachine()
       {
           IProcessor processor = this.Factory.GetProcessor();
           IHardDisk hdd = Factory.GetHardDisk();
           IMonitor monitor = Factory.GetMonitor();

           processor.PerformOperation();
           hdd.StoreData();
           monitor.Display();
       }
   }
}
