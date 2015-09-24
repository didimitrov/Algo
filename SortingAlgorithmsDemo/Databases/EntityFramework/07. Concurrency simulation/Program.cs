/*
 * 7. Try to open two different data contexts and perform concurrent 
 * changes on the same records. What will happen at SaveChanges()?
 * How to deal with it?
 */

using _01.DataModels;

namespace _07.Concurrency_simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var firstContext = new  NorthwindEntities())
            {
                using (var secondContext = new NorthwindEntities())
                {
                    firstContext.Customers.Add(new Customer { CustomerID = 5000, CompanyName = "CONFLICTTEST" });
                    secondContext.Customers.Add(new Customer {CustomerID = 6000, CompanyName = "CONFLICTTEST2"});
                    secondContext.SaveChanges();
                    firstContext.SaveChanges();

                    secondContext.SaveChanges();
                }
            }
        }
    }
}
