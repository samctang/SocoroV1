using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Repositories
{
    public interface IOperationProcessTypeRepository
    {
        IQueryable<OperationProcessType> OperationProcessTypes { get; }

        Task<List<OperationProcessType>> GetByTypeIdAsync(int operationTypeId);
    }
}
