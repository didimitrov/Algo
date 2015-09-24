/*
 * 9. Create a method that places a new order in the Northwind database.
 * The order should contain several order items. 
 * Use transaction to ensure the data consistency.
 */

using System;
using System.Linq;
using System.Transactions;
using _01.DataModels;

namespace _09.AddOrdersWithTransactions
{
    class Program
    {
        public static void AddOrder(string shipName, short amount, int productID, decimal unitPrice, float discount)
        {
            using (NorthwindEntities dbContent = new NorthwindEntities())
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    try
                    {
                        Order newOrder = new Order { ShipName = shipName };

                        dbContent.Orders.Add(newOrder);
                        dbContent.SaveChanges();

                        var result = dbContent.Orders.Where(x => x.ShipName == shipName);

                        using (NorthwindEntities dbContext = new NorthwindEntities())
                        {
                            foreach (var item in result)
                            {
                                Order_Detail newDetail = new Order_Detail
                                {
                                    OrderID = item.OrderID,
                                    ProductID = productID,
                                    UnitPrice = unitPrice,
                                    Discount = discount,
                                    Quantity = amount,
                                };

                                dbContext.Order_Details.Add(newDetail);
                                dbContext.SaveChanges();
                            }
                        }

                        scope.Complete();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            AddOrder("TESToooo", 12, 23, 0.1m, 0.05f);
        }
    }
}
