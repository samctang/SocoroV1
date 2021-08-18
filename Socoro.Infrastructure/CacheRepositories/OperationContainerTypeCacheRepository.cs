using Socoro.Application.Interfaces.CacheRepositories;
using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Socoro.Infrastructure.CacheKeys;
using Socoro.Application.Extensions;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationContainerTypeCacheRepository : IOperationContainerTypeCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IOperationContainerTypeRepository _operationContainerTypeRepository;

        public OperationContainerTypeCacheRepository(IDistributedCache distributedCache, IOperationContainerTypeRepository operationContainerTypeRepository)
        {
            _distributedCache = distributedCache;
            _operationContainerTypeRepository = operationContainerTypeRepository;
        }

        public async Task<OperationContainerType> GetByIdAsync(int operationContainerTypeId)
        {
            string cacheKey = OperationContainerTypeCacheKeys.GetKey(operationContainerTypeId);
            var operationContainerType = await _distributedCache.GetAsync<OperationContainerType>(cacheKey);
            if (operationContainerType == null)
            {
                operationContainerType = await _operationContainerTypeRepository.GetByIdAsync(operationContainerTypeId);
                await _distributedCache.SetAsync(cacheKey, operationContainerType);
            }
            return operationContainerType;
        }
    }
}
