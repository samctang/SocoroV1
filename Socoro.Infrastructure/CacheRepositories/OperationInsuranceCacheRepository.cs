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
    public class OperationInsuranceCacheRepository : IOperationInsuranceCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IOperationInsuranceRepository _operationInsuranceRepository;

        public OperationInsuranceCacheRepository(IDistributedCache distributedCache, IOperationInsuranceRepository operationInsuranceRepository)
        {
            _distributedCache = distributedCache;
            _operationInsuranceRepository = operationInsuranceRepository;
        }

        public async Task<OperationInsurance> GetByIdAsync(int operationInsuranceId)
        {
            string cacheKey = OperationInsuranceCacheKeys.GetKey(operationInsuranceId);
            var operationInsurance = await _distributedCache.GetAsync<OperationInsurance>(cacheKey);
            if (operationInsurance == null)
            {
                operationInsurance = await _operationInsuranceRepository.GetByIdAsync(operationInsuranceId);
                Throw.Exception.IfNull(operationInsurance, "OperationInsurance", "No OperationInsurance Found");
                await _distributedCache.SetAsync(cacheKey, operationInsurance);
            }
            return operationInsurance;
        }

        public async Task<List<OperationInsurance>> GetCachedListAsync()
        {
            string cacheKey = OperationInsuranceCacheKeys.ListKey;
            var operationInsuranceList = await _distributedCache.GetAsync<List<OperationInsurance>>(cacheKey);
            if (operationInsuranceList == null)
            {
                operationInsuranceList = await _operationInsuranceRepository.GetListAsync();
                await _distributedCache.SetAsync(cacheKey, operationInsuranceList);
            }
            return operationInsuranceList;
        }
    }
}