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
    public class OperationProcessTypeCacheRepository : IOperationProcessTypeCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IOperationProcessTypeRepository _operationProcessTypeRepository;

        public OperationProcessTypeCacheRepository(IDistributedCache distributedCache, IOperationProcessTypeRepository operationProcessTypeRepository)
        {
            _distributedCache = distributedCache;
            _operationProcessTypeRepository = operationProcessTypeRepository;
        }

        public async Task<List<OperationProcessType>> GetByTypeIdAsync(int operationTypeId)
        {
            string cacheKey = OperationProcessTypeCacheKeys.SelectListKey;
            var operationProcessTypeList = await _distributedCache.GetAsync<List<OperationProcessType>>(cacheKey);
            if (operationProcessTypeList == null)
            {
                operationProcessTypeList = await _operationProcessTypeRepository.GetByTypeIdAsync(operationTypeId);
                await _distributedCache.SetAsync(cacheKey, operationProcessTypeList);
            }
            return operationProcessTypeList;
        }

        public async Task<OperationProcessType> GetByIdAsync(int operationProcessTypeId)
        {
            string cacheKey = OperationProcessTypeCacheKeys.GetKey(operationProcessTypeId);
            var operationProcessType = await _distributedCache.GetAsync<OperationProcessType>(cacheKey);
            if (operationProcessType == null)
            {
                operationProcessType = await _operationProcessTypeRepository.GetByIdAsync(operationProcessTypeId);
                await _distributedCache.SetAsync(cacheKey, operationProcessType);
            }
            return operationProcessType;
        }
    }
}
