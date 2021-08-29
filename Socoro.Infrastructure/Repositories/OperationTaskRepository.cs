using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationTaskRepository : IOperationTaskRepository
    {
        private readonly IRepositoryAsync<OperationTask> _repository;

        public OperationTaskRepository(IRepositoryAsync<OperationTask> repository)
        {
            _repository = repository;
        }
        public IQueryable<OperationTask> OperationTasks => _repository.Entities;

        public async Task<List<OperationTask>> GetAllByOperationProcessIdAsync(int operationProcessId)
        {
            return await _repository.Entities.Where(p => p.OperationProcessId == operationProcessId).ToListAsync();
        }

        public async Task<List<OperationTask>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
        public async Task<int> InsertAsync(OperationTask operationTask)
        {
            await _repository.AddAsync(operationTask);
            return operationTask.Id;
        }
        public async Task UpdateAsync(OperationTask operationTask)
        {
            await _repository.UpdateAsync(operationTask);
        }
    }
}
