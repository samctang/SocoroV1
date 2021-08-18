using Socoro.Domain.Entities;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.CacheRepositories
{
    public interface IOperationContainerTypeCacheRepository
    {
        Task<OperationContainerType> GetByIdAsync(int operationContainerTypeId);
    }
}