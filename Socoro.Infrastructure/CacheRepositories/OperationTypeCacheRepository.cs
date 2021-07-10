using Socoro.Application.Interfaces.CacheRepositories;
using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Socoro.Infrastructure.CacheKeys;
using AspNetCoreHero.Extensions.Caching;
using AspNetCoreHero.ThrowR;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationTypeCacheRepository : IOperationTypeCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IOperationTypeRepository _operationTypeRepository;

        public OperationTypeCacheRepository(IDistributedCache distributedCache, IOperationTypeRepository operationTypeRepository)
        {
            _distributedCache = distributedCache;
            _operationTypeRepository = operationTypeRepository;
        }

        public async Task<OperationType> GetByIdAsync(int operationTypeId)
        {
            string cacheKey = OperationTypeCacheKeys.GetKey(operationTypeId);
            var operationType = await _distributedCache.GetAsync<OperationType>(cacheKey);
            if (operationType == null)
            {
                operationType = await _operationTypeRepository.GetByIdAsync(operationTypeId);
                Throw.Exception.IfNull(operationType, "OperationType", "No OperationType Found");
                await _distributedCache.SetAsync(cacheKey, operationType);
            }
            return operationType;
        }

        public async Task<List<OperationType>> GetCachedListAsync()
        {
            string cacheKey = OperationTypeCacheKeys.ListKey;
            var operationTypeList = await _distributedCache.GetAsync<List<OperationType>>(cacheKey);
            if (operationTypeList == null)
            {
                operationTypeList = await _operationTypeRepository.GetListAsync();
                await _distributedCache.SetAsync(cacheKey, operationTypeList);
            }
            return operationTypeList;
        }
    }
}
