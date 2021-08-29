using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Socoro.Infrastructure.Repositories
{
    public class OperationBookingRepository : IOperationBookingRepository
    {
        private readonly IRepositoryAsync<OperationBooking> _repository;

        public OperationBookingRepository(IRepositoryAsync<OperationBooking> repository)
        {
            _repository = repository;
        }
        public IQueryable<OperationBooking> OperationBookings => _repository.Entities;

        public async Task<OperationBooking> GetByIdAsync(int operationBookingId)
        {
            return await _repository.Entities.Where(p => p.Id == operationBookingId).FirstOrDefaultAsync();
        }
        public async Task<List<OperationBooking>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }
        public async Task<int> InsertAsync(OperationBooking operationBooking)
        {
            await _repository.AddAsync(operationBooking);
            return operationBooking.Id;
        }
        public async Task UpdateAsync(OperationBooking operationBooking)
        {
            await _repository.UpdateAsync(operationBooking);
        }
    }
}
