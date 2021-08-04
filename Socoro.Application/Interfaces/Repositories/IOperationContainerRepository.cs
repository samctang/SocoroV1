using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Repositories
{
    public interface IOperationContainerRepository
    {
        IQueryable<OperationContainer> OperationContainers { get; }

        Task<OperationContainer> GetByIdAsync(int operationContainerId);
        Task<List<OperationContainer>> GetListAsync();
        Task<int> InsertAsync(OperationContainer operationContainer);
        Task UpdateAsync(OperationContainer operationContainer);
    }
}