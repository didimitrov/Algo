using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using _01.DataModels;

namespace _02.NortwindDao
{
    public class NortwindDto
    {
        public void AddCustomer(Customer customer)
        {
            using (var context = new NorthwindEntities())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public Customer RemoveCustomer(Customer customer)
        {
            using (var context = new NorthwindEntities())
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }

            return customer;
        }

        public void DeleteCustomerById(int id)
        {
            using (var context = new NorthwindEntities())
            {
                var customer = context.Customers.FirstOrDefault(c => c.CustomerID == id);
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }

        public Customer ModifyCostomer(int id, string companyName)
        {
            using (var context = new NorthwindEntities())
            {
                var customer = context.Customers.SingleOrDefault(x => x.CustomerID == id);

                if (customer!=null)
                {
                    customer.CompanyName = companyName;
                }
                context.SaveChanges();

                return customer;
            }
        }
    }


}