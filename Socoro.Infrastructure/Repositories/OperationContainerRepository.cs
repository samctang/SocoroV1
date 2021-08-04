using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationContainerRepository : IOperationContainerRepository
    {
        private readonly IRepositoryAsync<OperationContainer> _repository;
        private readonly IDistributedCache _distributedCache;

        public OperationContainerRepository(IDistributedCache distributedCache, IRepositoryAsync<OperationContainer> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }
        public IQueryable<OperationContainer> OperationContainers => _repository.Entities;

        public async Task<OperationContainer> GetByIdAsync(int operationContainerId)
        {
            return await _repository.Entities.Where(p => p.Id == operationContainerId).FirstOrDefaultAsync();
        }
        public async Task<List<OperationContainer>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
        public async Task<int> InsertAsync(OperationContainer operationContainer)
        {
            await _repository.AddAsync(operationContainer);
            await _distributedCache.RemoveAsync(CacheKeys.OperationContainerCacheKeys.ListKey);
            return operationContainer.Id;
        }
        public async Task UpdateAsync(OperationContainer operationContainer)
        {
            await _repository.UpdateAsync(operationContainer);
            await _distributedCache.RemoveAsync(CacheKeys.OperationContainerCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.OperationContainerCacheKeys.GetKey(operationContainer.Id));
        }
    }
}
