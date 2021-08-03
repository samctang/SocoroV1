using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Repositories
{
    public interface IOperationCargoRepository
    {
        IQueryable<OperationCargo> OperationCargos { get; }

        Task<OperationCargo> GetByIdAsync(int operationCargoId);
        Task<List<OperationCargo>> GetListAsync();
        Task<int> InsertAsync(OperationCargo operationCargo);
        Task UpdateAsync(OperationCargo operationCargo);
    }
}