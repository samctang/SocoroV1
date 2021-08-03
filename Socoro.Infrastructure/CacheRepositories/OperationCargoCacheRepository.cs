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
    public class OperationCargoCacheRepository : IOperationCargoCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IOperationCargoRepository _operationCargoRepository;

        public OperationCargoCacheRepository(IDistributedCache distributedCache, IOperationCargoRepository operationCargoRepository)
        {
            _distributedCache = distributedCache;
            _operationCargoRepository = operationCargoRepository;
        }

        public async Task<OperationCargo> GetByIdAsync(int operationCargoId)
        {
            string cacheKey = OperationCargoCacheKeys.GetKey(operationCargoId);
            var operationCargo = await _distributedCache.GetAsync<OperationCargo>(cacheKey);
            if (operationCargo == null)
            {
                operationCargo = await _operationCargoRepository.GetByIdAsync(operationCargoId);
                Throw.Exception.IfNull(operationCargo, "OperationCargo", "No OperationCargo Found");
                await _distributedCache.SetAsync(cacheKey, operationCargo);
            }
            return operationCargo;
        }

        public async Task<List<OperationCargo>> GetCachedListAsync()
        {
            string cacheKey = OperationCargoCacheKeys.ListKey;
            var operationCargoList = await _distributedCache.GetAsync<List<OperationCargo>>(cacheKey);
            if (operationCargoList == null)
            {
                operationCargoList = await _operationCargoRepository.GetListAsync();
                await _distributedCache.SetAsync(cacheKey, operationCargoList);
            }
            return operationCargoList;
        }
    }
}