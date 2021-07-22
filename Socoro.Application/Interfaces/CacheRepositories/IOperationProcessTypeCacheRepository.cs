using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.CacheRepositories
{
    public interface IOperationProcessTypeCacheRepository
    {

        Task<List<OperationProcessType>> GetByTypeIdAsync(int operationTypeId);
    }
}
