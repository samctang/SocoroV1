using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationRepository : IOperationRepository
    {
        private readonly IRepositoryAsync<Operation> _repository;

        public OperationRepository(IRepositoryAsync<Operation> repository)
        {
            _repository = repository;
        }

        public IQueryable<Operation> Operations => _repository.Entities;

        public async Task DeleteAsync(Operation operation)
        {
            await _repository.DeleteAsync(operation);
        }

        public async Task<Operation> GetByIdAsync(int operationId)
        {
            return await _repository.Entities.Where(p => p.Id == operationId).FirstOrDefaultAsync();
        }
        public async Task<Operation> GetByOperationNoAsync(string operationNo)
        {
            return await _repository.Entities.Where(p => p.OperationNo == operationNo).FirstOrDefaultAsync();
        }

        public async Task<Operation> GetLastOperationByTypeIdAsync(int typeId)
        {
            return await _repository.Entities.Where(i => i.TypeId == typeId).OrderBy(x => x.Id).LastOrDefaultAsync();
        }

        public async Task<List<Operation>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(Operation operation)
        {
            await _repository.AddAsync(operation);
            return operation.Id;
        }

        public async Task UpdateAsync(Operation operation)
        {
            await _repository.UpdateAsync(operation);
        }
    }
}