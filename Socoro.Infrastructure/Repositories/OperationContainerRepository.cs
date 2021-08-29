using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationContainerRepository : IOperationContainerRepository
    {
        private readonly IRepositoryAsync<OperationContainer> _repository;

        public OperationContainerRepository(IRepositoryAsync<OperationContainer> repository)
        {
            _repository = repository;
        }
        public IQueryable<OperationContainer> OperationContainers => _repository.Entities;

        public async Task<OperationContainer> GetByIdAsync(int operationContainerId)
        {
            return await _repository.Entities.Where(p => p.Id == operationContainerId).FirstOrDefaultAsync();
        }
        public async Task<List<OperationContainer>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
        public async Task<int> InsertAsync(OperationContainer operationContainer)
        {
            await _repository.AddAsync(operationContainer);
            return operationContainer.Id;
        }
        public async Task UpdateAsync(OperationContainer operationContainer)
        {
            await _repository.UpdateAsync(operationContainer);
        }
    }
}
