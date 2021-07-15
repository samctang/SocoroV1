using Socoro.Application.Interfaces.CacheRepositories;
using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Socoro.Infrastructure.CacheKeys;
using AspNetCoreHero.Extensions.Caching;
using AspNetCoreHero.ThrowR;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.CacheRepositories
{
    public class CustomerCacheRepository : ICustomerCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly ICustomerRepository _customerRepository;

        public CustomerCacheRepository(IDistributedCache distributedCache, ICustomerRepository customerRepository)
        {
            _distributedCache = distributedCache;
            _customerRepository = customerRepository;
        }

        public async Task<Customer> GetByIdAsync(int customerId)
        {
            string cacheKey = CustomerCacheKeys.GetKey(customerId);
            var customer = await _distributedCache.GetAsync<Customer>(cacheKey);
            if (customer == null)
            {
                customer = await _customerRepository.GetByIdAsync(customerId);
                Throw.Exception.IfNull(customer, "Customer", "No Customer Found");
                await _distributedCache.SetAsync(cacheKey, customer);
            }
            return customer;
        }

        public async Task<List<Customer>> GetCachedListAsync()
        {
            string cacheKey = CustomerCacheKeys.ListKey;
            var customerList = await _distributedCache.GetAsync<List<Customer>>(cacheKey);
            if (customerList == null)
            {
                customerList = await _customerRepository.GetListAsync();
                await _distributedCache.SetAsync(cacheKey, customerList);
            }
            return customerList;
        }
    }
}