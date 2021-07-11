using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> Customers { get; }

        Task<List<Customer>> GetListAsync();

        Task<Customer> GetByIdAsync(int customerId);

        Task<int> InsertAsync(Customer customer);

        Task UpdateAsync(Customer customer);

        Task DeleteAsync(Customer customer);
    }
}
