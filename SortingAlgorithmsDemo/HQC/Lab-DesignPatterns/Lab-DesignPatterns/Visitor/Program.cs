using Visitor.Models.Visitors;

namespace CustomerService
{
    using CustomerService.Data;
    using CustomerService.Models;

    public class Program
    {
        private static void Main()
        {
            var repository = new CustomerRepository();

            var premiumCustomers = repository.GetPremiumCustomers();
            var discountVisitor = new DiscountRaiseVisitor();
            foreach (var premiumCustomer in premiumCustomers)
            {
                premiumCustomer.Accept(discountVisitor);
            }


            var freePrurchase = new FreePurchaseVisitor();
            var allCustomers = repository.GetAll();
            foreach (var customer in allCustomers)
            {
                customer.Accept(freePrurchase);
            }
        }
    }
}
