using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationRepository : IOperationRepository
    {
        private readonly IRepositoryAsync<Operation> _repository;
        private readonly IDistributedCache _distributedCache;

        public OperationRepository(IDistributedCache distributedCache, IRepositoryAsync<Operation> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }

        public IQueryable<Operation> Operations => _repository.Entities;

        public async Task DeleteAsync(Operation operation)
        {
            await _repository.DeleteAsync(operation);
            await _distributedCache.RemoveAsync(CacheKeys.OperationCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.OperationCacheKeys.GetKey(operation.Id));
        }

        public async Task<Operation> GetByIdAsync(int operationId)
        {
            return await _repository.Entities.Where(p => p.Id == operationId).FirstOrDefaultAsync();
        }
        public async Task<Operation> GetByOperationNoAsync(string operationNo)
        {
            return await _repository.Entities.Where(p => p.OperationNo == operationNo).FirstOrDefaultAsync();
        }

        public async Task<Operation> GetLastOperationByTypeIdAsync(int typeId)
        {
            return await _repository.Entities.Where(i => i.TypeId == typeId).OrderBy(x => x.Id).LastOrDefaultAsync();
        }

        public async Task<List<Operation>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(Operation operation)
        {
            await _repository.AddAsync(operation);
            await _distributedCache.RemoveAsync(CacheKeys.OperationCacheKeys.ListKey);
            return operation.Id;
        }

        public async Task UpdateAsync(Operation operation)
        {
            await _repository.UpdateAsync(operation);
            await _distributedCache.RemoveAsync(CacheKeys.OperationCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.OperationCacheKeys.GetKey(operation.Id));
        }
    }
}