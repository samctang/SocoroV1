using Socoro.Application.Interfaces.CacheRepositories;
using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Socoro.Infrastructure.CacheKeys;
using Socoro.Application.Extensions;
using Socoro.Application.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.CacheRepositories
{
    public class OperationBookingCacheRepository : IOperationBookingCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IOperationBookingRepository _operationBookingRepository;

        public OperationBookingCacheRepository(IDistributedCache distributedCache, IOperationBookingRepository operationBookingRepository)
        {
            _distributedCache = distributedCache;
            _operationBookingRepository = operationBookingRepository;
        }

        public async Task<OperationBooking> GetByIdAsync(int operationBookingId)
        {
            string cacheKey = OperationBookingCacheKeys.GetKey(operationBookingId);
            var operationBooking = await _distributedCache.GetAsync<OperationBooking>(cacheKey);
            if (operationBooking == null)
            {
                operationBooking = await _operationBookingRepository.GetByIdAsync(operationBookingId);
                Throw.Exception.IfNull(operationBooking, "OperationBooking", "No OperationBooking Found");
                await _distributedCache.SetAsync(cacheKey, operationBooking);
            }
            return operationBooking;
        }

        public async Task<List<OperationBooking>> GetCachedListAsync()
        {
            string cacheKey = OperationBookingCacheKeys.ListKey;
            var operationBookingList = await _distributedCache.GetAsync<List<OperationBooking>>(cacheKey);
            if (operationBookingList == null)
            {
                operationBookingList = await _operationBookingRepository.GetListAsync();
                await _distributedCache.SetAsync(cacheKey, operationBookingList);
            }
            return operationBookingList;
        }
    }
}