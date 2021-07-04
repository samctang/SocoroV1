using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.CacheRepositories
{
    public interface IOperationCacheRepository
    {
        Task<List<Operation>> GetCachedListAsync();

        Task<Operation> GetByIdAsync(int operationId);
    }
}
