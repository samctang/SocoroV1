using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationTaskRepository : IOperationTaskRepository
    {
        private readonly IRepositoryAsync<OperationTask> _repository;
        private readonly IDistributedCache _distributedCache;

        public OperationTaskRepository(IDistributedCache distributedCache, IRepositoryAsync<OperationTask> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }
        public IQueryable<OperationTask> OperationTasks => _repository.Entities;

        public async Task<OperationTask> GetByIdAsync(int operationProcessId)
        {
            return await _repository.Entities.Where(p => p.OperationProcessId == operationProcessId).FirstOrDefaultAsync();
        }
        public async Task<List<OperationTask>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
        public async Task<int> InsertAsync(OperationTask operationTask)
        {
            await _repository.AddAsync(operationTask);
            await _distributedCache.RemoveAsync(CacheKeys.OperationTaskCacheKeys.ListKey);
            return operationTask.Id;
        }
        public async Task UpdateAsync(OperationTask operationTask)
        {
            await _repository.UpdateAsync(operationTask);
            await _distributedCache.RemoveAsync(CacheKeys.OperationTaskCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.OperationTaskCacheKeys.GetKey(operationTask.Id));
        }
    }
}
