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

        DbSet<Company> Companies { get; set; }
        DbSet<CompanyType> CompanyTypes { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<EmployeeNote> EmployeeNotes { get; set; }
        DbSet<Operation> Operations { get; set; }
        DbSet<OperationProcess> OperationProcesses { get; set; }
        DbSet<OperationType> OperationTypes { get; set; }
        DbSet<OperationView> OperationViews { get; set; }

    }
}