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
    public class OperationCacheRepository : IOperationCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IOperationRepository _operationRepository;

        public OperationCacheRepository(IDistributedCache distributedCache, IOperationRepository operationRepository)
        {
            _distributedCache = distributedCache;
            _operationRepository = operationRepository;
        }

        public async Task<Operation> GetByIdAsync(int operationId)
        {
            string cacheKey = OperationCacheKeys.GetKey(operationId);
            var operation = await _distributedCache.GetAsync<Operation>(cacheKey);
            if (operation == null)
            {
                operation = await _operationRepository.GetByIdAsync(operationId);
                Throw.Exception.IfNull(operation, "Operation", "No Operation Found");
                await _distributedCache.SetAsync(cacheKey, operation);
            }
            return operation;
        }

        public async Task<List<Operation>> GetCachedListAsync()
        {
            string cacheKey = OperationCacheKeys.ListKey;
            var operationList = await _distributedCache.GetAsync<List<Operation>>(cacheKey);
            if (operationList == null)
            {
                operationList = await _operationRepository.GetListAsync();
                await _distributedCache.SetAsync(cacheKey, operationList);
            }
            return operationList;
        }
    }
}