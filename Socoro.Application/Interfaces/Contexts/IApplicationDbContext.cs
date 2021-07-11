using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Socoro.Application.Interfaces.Contexts
{
    public interface IApplicationDbContext
    {
        IDbConnection Connection { get; }
        bool HasChanges { get; }

        EntityEntry Entry(object entity);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        DbSet<Carrier> Carriers { get; set; }
        DbSet<CarrierType> CarrierTypes { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<CustomerType> CustomerTypes { get; set; }
        DbSet<EmployeeNote> EmployeeNotes { get; set; }
        DbSet<Operation> Operations { get; set; }
        DbSet<OperationProcess> OperationProcesses { get; set; }
        DbSet<OperationType> OperationTypes { get; set; }
        DbSet<OperationView> OperationViews { get; set; }

    }
}