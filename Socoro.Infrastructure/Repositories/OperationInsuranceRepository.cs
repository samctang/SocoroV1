using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationInsuranceRepository : IOperationInsuranceRepository
    {
        private readonly IRepositoryAsync<OperationInsurance> _repository;
        private readonly IDistributedCache _distributedCache;

        public OperationInsuranceRepository(IDistributedCache distributedCache, IRepositoryAsync<OperationInsurance> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }
        public IQueryable<OperationInsurance> OperationInsurances => _repository.Entities;

        public async Task<OperationInsurance> GetByIdAsync(int operationId)
        {
            return await _repository.Entities.Where(p => p.OperationId == operationId).FirstOrDefaultAsync();
        }
        public async Task<List<OperationInsurance>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
        public async Task<int> InsertAsync(OperationInsurance operationInsurance)
        {
            await _repository.AddAsync(operationInsurance);
            await _distributedCache.RemoveAsync(CacheKeys.OperationInsuranceCacheKeys.ListKey);
            return operationInsurance.Id;
        }
        public async Task UpdateAsync(OperationInsurance operationInsurance)
        {
            await _repository.UpdateAsync(operationInsurance);
            await _distributedCache.RemoveAsync(CacheKeys.OperationInsuranceCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.OperationInsuranceCacheKeys.GetKey(operationInsurance.Id));
        }
    }
}
