using CustomerService.Models;

namespace Visitor.Interfaces
{
    public interface ICustomerVisitor
    {
        void Visit(Customer customer);
    }
}
