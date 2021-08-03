using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.CacheRepositories
{
    public interface IOperationCargoCacheRepository
    {
        Task<OperationCargo> GetByIdAsync(int operationCargoId);
        Task<List<OperationCargo>> GetCachedListAsync();
    }
}