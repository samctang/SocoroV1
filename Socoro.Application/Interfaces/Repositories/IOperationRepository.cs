using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Repositories
{
    public interface IOperationRepository
    {
        IQueryable<Operation> Operations { get; }

        Task<List<Operation>> GetListAsync();

        Task<Operation> GetByIdAsync(int operationId);

        Task<int> InsertAsync(Operation operation);

        Task UpdateAsync(Operation operation);

        Task DeleteAsync(Operation operation);
    }
}
