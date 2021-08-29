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

        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<CarrierType> CarrierTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeNote> EmployeeNotes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<OperationProcess> OperationProcesses { get; set; }
        public DbSet<OperationProcessType> OperationProcessTypes { get; set; }
        public DbSet<OperationContainer> OperationContainers { get; set; }
        public DbSet<OperationContainerType> OperationContainerTypes { get; set; }
        public DbSet<OperationBooking> OperationBookings { get; set; }
        public DbSet<OperationBookingMessage> OperationBookingMessages { get; set; }
        public DbSet<OperationCargo> OperationCargos { get; set; }
        public DbSet<OperationQuote> OperationQuotes { get; set; }
        public DbSet<OperationInsurance> OperationInsurances { get; set; }
        public DbSet<OperationTask> OperationTasks { get; set; }
    }
}