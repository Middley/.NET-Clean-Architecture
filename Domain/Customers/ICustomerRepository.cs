using Domain.Customers;

namespace Doamin.Customers;

public interface ICustomerRepository
{
    Task<Customer> GetByIdAsync(CustomerId id);
    Task Add(Customer customer);
}