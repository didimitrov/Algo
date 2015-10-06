using CustomerService.Models;
using Visitor.Interfaces;

namespace Visitor.Models.Visitors
{
    class FreePurchaseVisitor:ICustomerVisitor
    {
        public void Visit(Customer customer)
        {
            customer.AddFreePurchase(new Purchase("SteamOp", 0.0));
        }
    }
}
