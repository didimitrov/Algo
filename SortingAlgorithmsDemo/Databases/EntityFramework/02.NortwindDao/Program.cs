/*
 * 2. Create a DAO class with static methods which provide 
 * functionality for inserting, modifying and deleting customers. 
 * Write a testing class.
 */
using _01.DataModels;

namespace _02.NortwindDao
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NortwindDto();

            var customer = new Customer
            {
                CustomerID = 5000,
                CompanyName = "Our Company Inc.",
                ContactName = "Pesho",
                ContactTitle = "Test Title"
            };

            //Console.WriteLine("{0} customer(s) added.", db.AddCustomer(customer));

            //Console.WriteLine("{0} customer(s) updated.", db.ModifyCostomer(5000, "Some other Company"));

            //Console.WriteLine("{0} customer(s) deleted.", db.DeleteCustomerById(5000));
        }
    }
}
