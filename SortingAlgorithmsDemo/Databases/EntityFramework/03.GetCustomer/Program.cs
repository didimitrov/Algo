using System;
using System.Linq;
using _01.DataModels;

namespace _03.GetCustomer
{
    class Program
    {
        public static void CustomersWithOrders(int orderedDate, string destination)
        {
            using (var context = new NorthwindEntities())
            {
                var query =
                    context.Orders.Where(o => o.OrderDate.Value.Year == orderedDate && o.ShipAddress == destination)
                        .Select(o => o.Customer);

                foreach (var customer in query)
                {
                    Console.WriteLine(customer.ContactName);
                }
            }
        }
        static void Main(string[] args)
        {
            CustomersWithOrders(1997,"Canada");
        }
    }
}
