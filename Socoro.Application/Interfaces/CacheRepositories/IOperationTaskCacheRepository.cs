using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.CacheRepositories
{
    public interface IOperationTaskCacheRepository
    {
        Task<OperationTask> GetByIdAsync(int operationTaskId);
        Task<List<OperationTask>> GetCachedListAsync();
    }
}