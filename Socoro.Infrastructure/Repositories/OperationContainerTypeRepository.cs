using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationContainerTypeRepository : IOperationContainerTypeRepository
    {
        private readonly IRepositoryAsync<OperationContainerType> _repository;
        public OperationContainerTypeRepository(IRepositoryAsync<OperationContainerType> repository)
        {
            _repository = repository;
        }

        public IQueryable<OperationContainerType> OperationContainerTypes => _repository.Entities;

        public async Task<OperationContainerType> GetByIdAsync(int operationContainerTypeId)
        {
            return await _repository.Entities.Where(p => p.Id == operationContainerTypeId).FirstOrDefaultAsync();
        }

    }
}
