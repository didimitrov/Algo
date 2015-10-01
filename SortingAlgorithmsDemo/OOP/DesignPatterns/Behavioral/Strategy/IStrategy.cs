namespace Strategy
{
   public interface IStrategy
   {
       int DoOperations(int a, int b);
   }

    public class OperationAdd : IStrategy
    {
        public int DoOperations(int a, int b)
        {
            return a + b;
        }
    }

    public class OperationSubtract : IStrategy
    {
        public int DoOperations(int a, int b)
        {
            return a - b;
        }
    }

    public class OperationMultiply : IStrategy
    {
        public int DoOperations(int a, int b)
        {
            return a*b;
        }
    }
}
