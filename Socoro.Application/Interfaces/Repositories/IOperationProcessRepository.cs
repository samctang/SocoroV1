using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Repositories
{
    public interface IOperationProcessRepository
    {
        IQueryable<OperationProcess> OperationProcesses { get; }

        Task<OperationProcess> GetByIdAsync(int operationId);

        Task<int> InsertAsync(OperationProcess operationProcess);

        Task UpdateAsync(OperationProcess operationProcess);
        Task<OperationProcess> GetOperationIdById(int id);
        Task<List<OperationProcess>> GetByOperationIdAsync(int operationId);
        Task<OperationProcess> GetIdByOperationIdAndTypeIdAsync(int operationId, int typeId);
    }
}
