using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationContainerTypeRepository : IOperationContainerTypeRepository
    {
        private readonly IRepositoryAsync<OperationContainerType> _repository;
        private readonly IDistributedCache _distributedCache;
        public OperationContainerTypeRepository(IDistributedCache distributedCache, IRepositoryAsync<OperationContainerType> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }

        public IQueryable<OperationContainerType> OperationContainerTypes => _repository.Entities;

        public async Task<OperationContainerType> GetByIdAsync(int operationContainerTypeId)
        {
            return await _repository.Entities.Where(p => p.Id == operationContainerTypeId).FirstOrDefaultAsync();
        }

    }
}
