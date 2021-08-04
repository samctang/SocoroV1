using Socoro.Application.Interfaces.CacheRepositories;
using Socoro.Application.Interfaces.Contexts;
using Socoro.Application.Interfaces.Repositories;
using Socoro.Infrastructure.CacheRepositories;
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
            services.AddTransient<ICustomerCacheRepository, CustomerCacheRepository>();
            services.AddTransient<IOperationRepository, OperationRepository>();
            services.AddTransient<IOperationCacheRepository, OperationCacheRepository>();
            services.AddTransient<IOperationTypeRepository, OperationTypeRepository>();
            services.AddTransient<IOperationTypeCacheRepository, OperationTypeCacheRepository>();
            services.AddTransient<IOperationProcessRepository, OperationProcessRepository>();
            services.AddTransient<IOperationProcessTypeRepository, OperationProcessTypeRepository>();
            services.AddTransient<IOperationProcessTypeCacheRepository, OperationProcessTypeCacheRepository>();
            services.AddTransient<IOperationCargoRepository, OperationCargoRepository>();
            services.AddTransient<IOperationCargoCacheRepository, OperationCargoCacheRepository>();
            services.AddTransient<IOperationBookingRepository, OperationBookingRepository>();
            services.AddTransient<IOperationBookingCacheRepository, OperationBookingCacheRepository>();
            services.AddTransient<IOperationQuoteRepository, OperationQuoteRepository>();
            services.AddTransient<IOperationQuoteCacheRepository, OperationQuoteCacheRepository>();
            services.AddTransient<IOperationContainerRepository, OperationContainerRepository>();
            services.AddTransient<IOperationContainerCacheRepository, OperationContainerCacheRepository>();
            services.AddTransient<ILogRepository, LogRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #endregion Repositories
        }
    }
}