using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.CacheRepositories
{
    public interface IOperationBookingCacheRepository
    {
        Task<OperationBooking> GetByIdAsync(int operationBookingId);
        Task<List<OperationBooking>> GetCachedListAsync();
    }
}