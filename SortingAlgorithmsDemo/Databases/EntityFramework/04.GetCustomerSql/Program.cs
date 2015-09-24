using System;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using _01.DataModels;

namespace _04.GetCustomerSql
{
    class Program
    {
        public static void GetCustomerSql(int orderedYear, string destination)
        {
            using (var context = new NorthwindEntities())
            {
                var searchQuery =
                    @"SELECT c.ContactName from Customers
                                    c INNER JOIN Orders o ON o.CustomerID = c.CustomerID 
                                    WHERE (YEAR(o.OrderDate) = {0} AND o.ShipCountry = {1});";

                object[] queryParams = { orderedYear, destination };

                var searchResult = context.Database.SqlQuery<string>(searchQuery, queryParams);

                foreach (var customer in searchResult)
                {
                    Console.WriteLine("Customer: {0}", customer);
                }

                //var query = (from customer in context.Customers
                //    join order in context.Orders on customer.CustomerID equals order.CustomerID
                //    where order.OrderDate.Value.Year == 1994 && order.ShipCountry == "Canada"
                //    select customer).ToList();

            }
        }


        static void Main(string[] args)
        {
            GetCustomerSql(1997, "Canada");
        }
    }
}
