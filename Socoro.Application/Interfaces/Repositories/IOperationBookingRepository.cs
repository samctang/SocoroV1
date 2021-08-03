using Socoro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Repositories
{
    public interface IOperationBookingRepository
    {
        IQueryable<OperationBooking> OperationBookings { get; }

        Task<OperationBooking> GetByIdAsync(int operationBookingId);
        Task<List<OperationBooking>> GetListAsync();
        Task<int> InsertAsync(OperationBooking operationBooking);
        Task UpdateAsync(OperationBooking operationBooking);
    }
}