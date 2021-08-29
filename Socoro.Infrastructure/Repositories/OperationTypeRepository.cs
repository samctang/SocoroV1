using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationTypeRepository : IOperationTypeRepository
    {
        private readonly IRepositoryAsync<OperationType> _repository;
        public OperationTypeRepository(IRepositoryAsync<OperationType> repository)
        {
            _repository = repository;
        }

        public IQueryable<OperationType> OperationTypes => _repository.Entities;

        public async Task<OperationType> GetByIdAsync(int operationId)
        {
            return await _repository.Entities.Where(p => p.Id == operationId).FirstOrDefaultAsync();
        }

        public async Task<List<OperationType>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
    }
}
