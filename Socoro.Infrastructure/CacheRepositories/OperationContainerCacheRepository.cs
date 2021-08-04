using Socoro.Application.Interfaces.CacheRepositories;
using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Socoro.Infrastructure.CacheKeys;
using Socoro.Application.Extensions;
using Socoro.Application.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.CacheRepositories
{
    public class OperationContainerCacheRepository : IOperationContainerCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IOperationContainerRepository _operationContainerRepository;

        public OperationContainerCacheRepository(IDistributedCache distributedCache, IOperationContainerRepository operationContainerRepository)
        {
            _distributedCache = distributedCache;
            _operationContainerRepository = operationContainerRepository;
        }

        public async Task<OperationContainer> GetByIdAsync(int operationContainerId)
        {
            string cacheKey = OperationContainerCacheKeys.GetKey(operationContainerId);
            var operationContainer = await _distributedCache.GetAsync<OperationContainer>(cacheKey);
            if (operationContainer == null)
            {
                operationContainer = await _operationContainerRepository.GetByIdAsync(operationContainerId);
                Throw.Exception.IfNull(operationContainer, "OperationContainer", "No OperationContainer Found");
                await _distributedCache.SetAsync(cacheKey, operationContainer);
            }
            return operationContainer;
        }

        public async Task<List<OperationContainer>> GetCachedListAsync()
        {
            string cacheKey = OperationContainerCacheKeys.ListKey;
            var operationContainerList = await _distributedCache.GetAsync<List<OperationContainer>>(cacheKey);
            if (operationContainerList == null)
            {
                operationContainerList = await _operationContainerRepository.GetListAsync();
                await _distributedCache.SetAsync(cacheKey, operationContainerList);
            }
            return operationContainerList;
        }
    }
}