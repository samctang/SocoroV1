using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Repositories
{
    public interface IOperationTaskRepository
    {
        IQueryable<OperationTask> OperationTasks { get; }

        Task<List<OperationTask>> GetAllByOperationProcessIdAsync(int operationProcessId);
        Task<List<OperationTask>> GetListAsync();
        Task<int> InsertAsync(OperationTask operationTask);
        Task UpdateAsync(OperationTask operationTask);
        Task<OperationTask> GetByIdAsync(int id);
    }
}