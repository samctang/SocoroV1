using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Repositories
{
    public interface IOperationQuoteRepository
    {
        IQueryable<OperationQuote> OperationQuotes { get; }

        Task<OperationQuote> GetByIdAsync(int operationQuoteId);
        Task<List<OperationQuote>> GetListAsync();
        Task<int> InsertAsync(OperationQuote operationQuote);
        Task UpdateAsync(OperationQuote operationQuote);
    }
}