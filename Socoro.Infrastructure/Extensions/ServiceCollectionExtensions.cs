
using Socoro.Application.Interfaces.Contexts;
using Socoro.Application.Interfaces.Repositories;

using Socoro.Infrastructure.DbContexts;
using Socoro.Infrastructure.Repositories;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Socoro.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddPersistenceContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            #region Repositories

            services.AddTransient(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
            services.AddTransient<ICustomerRepository, CustomerRepository>();

            services.AddTransient<IOperationRepository, OperationRepository>();

            services.AddTransient<IOperationTypeRepository, OperationTypeRepository>();

            services.AddTransient<IOperationProcessRepository, OperationProcessRepository>();
            services.AddTransient<IOperationProcessTypeRepository, OperationProcessTypeRepository>();

            services.AddTransient<IOperationCargoRepository, OperationCargoRepository>();

            services.AddTransient<IOperationBookingRepository, OperationBookingRepository>();

            services.AddTransient<IOperationQuoteRepository, OperationQuoteRepository>();

            services.AddTransient<IOperationContainerRepository, OperationContainerRepository>();

            services.AddTransient<IOperationTaskRepository, OperationTaskRepository>();

            services.AddTransient<ILogRepository, LogRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #endregion Repositories
        }
    }
}