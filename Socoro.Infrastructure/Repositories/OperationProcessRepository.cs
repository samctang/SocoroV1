using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationProcessRepository : IOperationProcessRepository
    {
        private readonly IRepositoryAsync<OperationProcess> _repository;

        public OperationProcessRepository(IDistributedCache distributedCache, IRepositoryAsync<OperationProcess> repository)
        {
            _repository = repository;
        }

        public IQueryable<OperationProcess> OperationProcesses => _repository.Entities;


        public async Task<OperationProcess> GetByIdAsync(int id)
        {
            return await _repository.Entities.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<OperationProcess>> GetByOperationIdAsync(int operationId)
        {
            return await _repository.Entities.Where(p => p.OperationId == operationId).ToListAsync();
        }

        public async Task<OperationProcess> GetIdByOperationIdAndTypeIdAsync(int operationId, int typeId)
        {
            return await _repository.Entities.Where(p => p.OperationId == operationId && p.TypeId == typeId).FirstOrDefaultAsync();
        }

        public async Task<OperationProcess> GetOperationIdById(int id)
        {
            return await _repository.Entities.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> InsertAsync(OperationProcess operationProcess)
        {
            await _repository.AddAsync(operationProcess);
            return operationProcess.Id;
        }

        public async Task UpdateAsync(OperationProcess operationProcess)
        {
            await _repository.UpdateAsync(operationProcess);
        }
    }
}
