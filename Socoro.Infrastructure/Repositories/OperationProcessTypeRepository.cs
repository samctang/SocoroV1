using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationProcessTypeRepository : IOperationProcessTypeRepository
    {
        private readonly IRepositoryAsync<OperationProcessType> _repository;
        public OperationProcessTypeRepository(IRepositoryAsync<OperationProcessType> repository)
        {
            _repository = repository;
        }

        public IQueryable<OperationProcessType> OperationProcessTypes => _repository.Entities;

        public async Task<List<OperationProcessType>> GetByTypeIdAsync(int operationTypeId)
        {
            return await _repository.Entities.Where(p => p.OperationTypeId == operationTypeId).ToListAsync();
        }
        public async Task<OperationProcessType> GetByIdAsync(int operationProcessTypeId)
        {
            return await _repository.Entities.Where(p => p.Id == operationProcessTypeId).FirstOrDefaultAsync();
        }

    }
}
