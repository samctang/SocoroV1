using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationInsuranceRepository : IOperationInsuranceRepository
    {
        private readonly IRepositoryAsync<OperationInsurance> _repository;

        public OperationInsuranceRepository(IRepositoryAsync<OperationInsurance> repository)
        {
            _repository = repository;
        }
        public IQueryable<OperationInsurance> OperationInsurances => _repository.Entities;

        public async Task<OperationInsurance> GetByIdAsync(int operationId)
        {
            return await _repository.Entities.Where(p => p.OperationId == operationId).FirstOrDefaultAsync();
        }
        public async Task<List<OperationInsurance>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
        public async Task<int> InsertAsync(OperationInsurance operationInsurance)
        {
            await _repository.AddAsync(operationInsurance);
            return operationInsurance.Id;
        }
        public async Task UpdateAsync(OperationInsurance operationInsurance)
        {
            await _repository.UpdateAsync(operationInsurance);
        }
    }
}
