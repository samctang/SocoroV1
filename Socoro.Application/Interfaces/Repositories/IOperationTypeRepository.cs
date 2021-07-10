using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Repositories
{
    public interface IOperationTypeRepository
    {
        IQueryable<OperationType> OperationTypes { get; }

        Task<List<OperationType>> GetListAsync();

        Task<OperationType> GetByIdAsync(int operationTypeId);
    }
}
