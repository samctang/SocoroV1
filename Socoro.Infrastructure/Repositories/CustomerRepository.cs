using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IRepositoryAsync<Customer> _repository;
        private readonly IDistributedCache _distributedCache;

        public CustomerRepository(IDistributedCache distributedCache, IRepositoryAsync<Customer> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }

        public IQueryable<Customer> Customers => _repository.Entities;

        public async Task DeleteAsync(Customer customer)
        {
            await _repository.DeleteAsync(customer);
            await _distributedCache.RemoveAsync(CacheKeys.CustomerCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.CustomerCacheKeys.GetKey(customer.Id));
            await _distributedCache.RemoveAsync(CacheKeys.CustomerCacheKeys.CompanyListKey);
        }

        public async Task<Customer> GetByIdAsync(int customerId)
        {
            return await _repository.Entities.Where(p => p.Id == customerId).FirstOrDefaultAsync();
        }

        public async Task<List<Customer>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(Customer customer)
        {
            await _repository.AddAsync(customer);
            await _distributedCache.RemoveAsync(CacheKeys.CustomerCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.CustomerCacheKeys.CompanyListKey);
            return customer.Id;
        }

        public async Task UpdateAsync(Customer customer)
        {
            await _repository.UpdateAsync(customer);
            await _distributedCache.RemoveAsync(CacheKeys.CustomerCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.CustomerCacheKeys.GetKey(customer.Id));
            await _distributedCache.RemoveAsync(CacheKeys.CustomerCacheKeys.CompanyListKey);
        }
        public async Task<List<Customer>> GetByCompanyIdAsync(int companyId)
        {
            return await _repository.Entities.Where(p => p.CompanyId == companyId).ToListAsync();
        }
    }
}