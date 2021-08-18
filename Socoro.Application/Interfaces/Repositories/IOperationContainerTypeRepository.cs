using Socoro.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Repositories
{
    public interface IOperationContainerTypeRepository
    {
        IQueryable<OperationContainerType> OperationContainerTypes { get; }

        Task<OperationContainerType> GetByIdAsync(int operationProcessTypeId);
    }
}