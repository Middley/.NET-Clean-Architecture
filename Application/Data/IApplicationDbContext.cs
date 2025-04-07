using Domain.Customers;
using Microsoft.EntityFrameworkCore;
namespace Application.Data;

public interface IApplicationDbcontext 
{
    DbSet<Customer> Customer {get; set;}
    Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
}