using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Socoro.Model.Entities;
using Socoro.Data.Core;
using Microsoft.EntityFrameworkCore.Migrations;


namespace Socoro.Data
{
    public class DatabaseContext : BaseContext
    {
        public DatabaseContext(string connectStringName)
            : base(connectionStringName)
        {
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeNote> EmployeeNotes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<OperationProcess> OperationProcesses { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<OperationView> OperationViews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
