using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationQuoteRepository : IOperationQuoteRepository
    {
        private readonly IRepositoryAsync<OperationQuote> _repository;

        public OperationQuoteRepository(IRepositoryAsync<OperationQuote> repository)
        {
            _repository = repository;
        }
        public IQueryable<OperationQuote> OperationQuotes => _repository.Entities;

        public async Task<OperationQuote> GetByIdAsync(int operationQuoteId)
        {
            return await _repository.Entities.Where(p => p.Id == operationQuoteId).FirstOrDefaultAsync();
        }
        public async Task<List<OperationQuote>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
        public async Task<int> InsertAsync(OperationQuote operationQuote)
        {
            await _repository.AddAsync(operationQuote);
            return operationQuote.Id;
        }
        public async Task UpdateAsync(OperationQuote operationQuote)
        {
            await _repository.UpdateAsync(operationQuote);
        }
    }
}
