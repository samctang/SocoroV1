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
    public class OperationTaskCacheRepository : IOperationTaskCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IOperationTaskRepository _operationTaskRepository;

        public OperationTaskCacheRepository(IDistributedCache distributedCache, IOperationTaskRepository operationTaskRepository)
        {
            _distributedCache = distributedCache;
            _operationTaskRepository = operationTaskRepository;
        }

        public async Task<OperationTask> GetByIdAsync(int operationTaskId)
        {
            string cacheKey = OperationTaskCacheKeys.GetKey(operationTaskId);
            var operationTask = await _distributedCache.GetAsync<OperationTask>(cacheKey);
            if (operationTask == null)
            {
                operationTask = await _operationTaskRepository.GetByIdAsync(operationTaskId);
                Throw.Exception.IfNull(operationTask, "OperationTask", "No OperationTask Found");
                await _distributedCache.SetAsync(cacheKey, operationTask);
            }
            return operationTask;
        }

        public async Task<List<OperationTask>> GetCachedListAsync()
        {
            string cacheKey = OperationTaskCacheKeys.ListKey;
            var operationTaskList = await _distributedCache.GetAsync<List<OperationTask>>(cacheKey);
            if (operationTaskList == null)
            {
                operationTaskList = await _operationTaskRepository.GetListAsync();
                await _distributedCache.SetAsync(cacheKey, operationTaskList);
            }
            return operationTaskList;
        }
    }
}