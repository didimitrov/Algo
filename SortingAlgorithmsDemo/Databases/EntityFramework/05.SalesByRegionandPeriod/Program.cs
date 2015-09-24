/*
 * 5. Write a method that finds all the sales 
 * by specified region and period (start / end dates).
 */
using System;
using System.Linq;
using _01.DataModels;

namespace _05.SalesByRegionandPeriod
{
    class Program
    {
        public static IQueryable<Order> FindSales(string region, DateTime start, DateTime end)
        {
            using (var context = new NorthwindEntities())
            {
                var query = context.Orders
                    .Where(c => c.ShipRegion == region && c.OrderDate >= start && c.OrderDate <= end).Select(o => o);

                return query;

                //foreach (var order in query)
                //{
                //    Console.WriteLine("Ship name: {0}, Ship region: {1}", order.ShipName, order.ShipRegion);
                //}
            }    
        }

        static void Main(string[] args)
        {
            var startDate = new DateTime(1995, 5, 10);
            var endDate = new DateTime(1996, 12, 4);

           var sales = FindSales("Canada", startDate, endDate);

          foreach (var order in sales)
          {
              Console.WriteLine("Ship name: {0}, Ship region: {1}", order.ShipName, order.ShipRegion);
          }
        }
    }
}
 