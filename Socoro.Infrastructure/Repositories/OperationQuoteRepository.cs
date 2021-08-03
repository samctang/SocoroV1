using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationQuoteRepository : IOperationQuoteRepository
    {
        private readonly IRepositoryAsync<OperationQuote> _repository;
        private readonly IDistributedCache _distributedCache;

        public OperationQuoteRepository(IDistributedCache distributedCache, IRepositoryAsync<OperationQuote> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }
        public IQueryable<OperationQuote> OperationQuotes => _repository.Entities;

        public async Task<OperationQuote> GetByIdAsync(int operationQuoteId)
        {
            return await _repository.Entities.Where(p => p.Id == operationQuoteId).FirstOrDefaultAsync();
        }
        public async Task<List<OperationQuote>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
        public async Task<int> InsertAsync(OperationQuote operationQuote)
        {
            await _repository.AddAsync(operationQuote);
            await _distributedCache.RemoveAsync(CacheKeys.OperationQuoteCacheKeys.ListKey);
            return operationQuote.Id;
        }
        public async Task UpdateAsync(OperationQuote operationQuote)
        {
            await _repository.UpdateAsync(operationQuote);
            await _distributedCache.RemoveAsync(CacheKeys.OperationQuoteCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.OperationQuoteCacheKeys.GetKey(operationQuote.Id));
        }
    }
}
