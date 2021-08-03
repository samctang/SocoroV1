using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.CacheRepositories
{
    public interface IOperationQuoteCacheRepository
    {
        Task<OperationQuote> GetByIdAsync(int operationQuoteId);
        Task<List<OperationQuote>> GetCachedListAsync();
    }
}