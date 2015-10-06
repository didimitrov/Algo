using CustomerService.Models;
using Visitor.Interfaces;

namespace Visitor.Models.Visitors
{
    class DiscountRaiseVisitor:ICustomerVisitor
    {
        public void Visit(Customer customer)
        {
            customer.RaiseDiscount(0.5);
        }
    }
}
