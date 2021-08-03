using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationBookingRepository : IOperationBookingRepository
    {
        private readonly IRepositoryAsync<OperationBooking> _repository;
        private readonly IDistributedCache _distributedCache;

        public OperationBookingRepository(IDistributedCache distributedCache, IRepositoryAsync<OperationBooking> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }
        public IQueryable<OperationBooking> OperationBookings => _repository.Entities;

        public async Task<OperationBooking> GetByIdAsync(int operationBookingId)
        {
            return await _repository.Entities.Where(p => p.Id == operationBookingId).FirstOrDefaultAsync();
        }
        public async Task<List<OperationBooking>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
        public async Task<int> InsertAsync(OperationBooking operationBooking)
        {
            await _repository.AddAsync(operationBooking);
            await _distributedCache.RemoveAsync(CacheKeys.OperationBookingCacheKeys.ListKey);
            return operationBooking.Id;
        }
        public async Task UpdateAsync(OperationBooking operationBooking)
        {
            await _repository.UpdateAsync(operationBooking);
            await _distributedCache.RemoveAsync(CacheKeys.OperationBookingCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.OperationBookingCacheKeys.GetKey(operationBooking.Id));
        }
    }
}
