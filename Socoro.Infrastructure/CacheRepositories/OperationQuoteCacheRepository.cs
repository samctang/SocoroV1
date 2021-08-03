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
    public class OperationQuoteCacheRepository : IOperationQuoteCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IOperationQuoteRepository _operationQuoteRepository;

        public OperationQuoteCacheRepository(IDistributedCache distributedCache, IOperationQuoteRepository operationQuoteRepository)
        {
            _distributedCache = distributedCache;
            _operationQuoteRepository = operationQuoteRepository;
        }

        public async Task<OperationQuote> GetByIdAsync(int operationQuoteId)
        {
            string cacheKey = OperationQuoteCacheKeys.GetKey(operationQuoteId);
            var operationQuote = await _distributedCache.GetAsync<OperationQuote>(cacheKey);
            if (operationQuote == null)
            {
                operationQuote = await _operationQuoteRepository.GetByIdAsync(operationQuoteId);
                Throw.Exception.IfNull(operationQuote, "OperationQuote", "No OperationQuote Found");
                await _distributedCache.SetAsync(cacheKey, operationQuote);
            }
            return operationQuote;
        }

        public async Task<List<OperationQuote>> GetCachedListAsync()
        {
            string cacheKey = OperationQuoteCacheKeys.ListKey;
            var operationQuoteList = await _distributedCache.GetAsync<List<OperationQuote>>(cacheKey);
            if (operationQuoteList == null)
            {
                operationQuoteList = await _operationQuoteRepository.GetListAsync();
                await _distributedCache.SetAsync(cacheKey, operationQuoteList);
            }
            return operationQuoteList;
        }
    }
}