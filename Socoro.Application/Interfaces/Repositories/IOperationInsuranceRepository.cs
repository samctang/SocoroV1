using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Repositories
{
    public interface IOperationInsuranceRepository
    {
        IQueryable<OperationInsurance> OperationInsurances { get; }

        Task<OperationInsurance> GetByIdAsync(int operationId);
        Task<List<OperationInsurance>> GetListAsync();
        Task<int> InsertAsync(OperationInsurance operationInsurance);
        Task UpdateAsync(OperationInsurance operationInsurance);
    }
}