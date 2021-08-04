using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.CacheRepositories
{
    public interface IOperationContainerCacheRepository
    {
        Task<OperationContainer> GetByIdAsync(int operationContainerId);
        Task<List<OperationContainer>> GetCachedListAsync();
    }
}