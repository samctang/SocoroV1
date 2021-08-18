using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.CacheRepositories
{
    public interface IOperationInsuranceCacheRepository
    {
        Task<OperationInsurance> GetByIdAsync(int operationInsuranceId);
        Task<List<OperationInsurance>> GetCachedListAsync();
    }
}