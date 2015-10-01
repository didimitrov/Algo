namespace Strategy
{
   public class Context
   {
       public Context(IStrategy strategy)
       {
           this.Strategy = strategy;
       }

       public IStrategy Strategy { get; private set; }

       public int ExecuteStrategy(int a,int b)
       {
           return this.Strategy.DoOperations(a, b);
       }
   }
}
