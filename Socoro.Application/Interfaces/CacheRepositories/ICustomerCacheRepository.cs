using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.CacheRepositories
{
    public interface ICustomerCacheRepository
    {
        Task<List<Customer>> GetCachedListAsync();

        Task<Customer> GetByIdAsync(int customerId);
    }
}
