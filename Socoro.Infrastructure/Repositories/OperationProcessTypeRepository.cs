using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationProcessTypeRepository : IOperationProcessTypeRepository
    {
        private readonly IRepositoryAsync<OperationProcessType> _repository;
        private readonly IDistributedCache _distributedCache;
        public OperationProcessTypeRepository(IDistributedCache distributedCache, IRepositoryAsync<OperationProcessType> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }

        public IQueryable<OperationProcessType> OperationProcessTypes => _repository.Entities;

        public async Task<List<OperationProcessType>> GetByTypeIdAsync(int operationProcessTypeId)
        {
            return await _repository.Entities.Where(p => p.TypeId == operationProcessTypeId).ToListAsync();
        }
    }
}
