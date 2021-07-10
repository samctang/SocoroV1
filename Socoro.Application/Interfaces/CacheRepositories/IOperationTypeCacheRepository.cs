using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.CacheRepositories
{
    public interface IOperationTypeCacheRepository
    {
        Task<List<OperationType>> GetCachedListAsync();

        Task<OperationType> GetByIdAsync(int operationTypeId);
    }
}
