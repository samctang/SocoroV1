using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationCargoRepository : IOperationCargoRepository
    {
        private readonly IRepositoryAsync<OperationCargo> _repository;

        public OperationCargoRepository(IRepositoryAsync<OperationCargo> repository)
        {
            _repository = repository;
        }
        public IQueryable<OperationCargo> OperationCargos => _repository.Entities;

        public async Task<OperationCargo> GetByIdAsync(int operationCargoId)
        {
            return await _repository.Entities.Where(p => p.Id == operationCargoId).FirstOrDefaultAsync();
        }
        public async Task<List<OperationCargo>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
        public async Task<int> InsertAsync(OperationCargo operationCargo)
        {
            await _repository.AddAsync(operationCargo);
            return operationCargo.Id;
        }
        public async Task UpdateAsync(OperationCargo operationCargo)
        {
            await _repository.UpdateAsync(operationCargo);
        }
    }
}
