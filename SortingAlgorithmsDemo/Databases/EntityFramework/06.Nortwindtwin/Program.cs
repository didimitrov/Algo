using System;
using System.Linq;
using _01.DataModels;

namespace _06.Nortwindtwin
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities dbContent = new NorthwindEntities();

            /* 
             * Steps to reproduse the DB:
             * 1. Open SorceModel.edmx
             * 2. Right button click on the empty space between the tables
             * 3. Click Generate Database from model - it will generate a SQL script
             * 4. Edit the USE [Northwind]; to the name of the database you want to clone the current DB to.
             * 5. Run the script;
             */



            // The connection string in App.config is changed
            Console.Write("Loading...");

            using (var northwindEntities = new NorthwindEntities())
            {
                northwindEntities.Database.CreateIfNotExists();
                Console.WriteLine("\rNumbers of customers: " + northwindEntities.Customers.Count());
            }
        }
    }
}
