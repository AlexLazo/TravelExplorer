using Application.Data;
using Domain.Customers;
using Domain.Primitives;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

<<<<<<< HEAD
namespace Infrastructure
{
    public static class AddPersistenceService
    {
        public static IServiceCollection AddPersistenceServiceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistence(configuration);
            return services;
        }

        private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

            services.AddScoped<IApplicationDbContext>(sp => sp.GetRequiredService<ApplicationDbContext>());
            services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<ApplicationDbContext>());
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}
=======
namespace Infrastructure;

public static class AddPersistenceService
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddPersistence(configuration);
        return services;
    }

    private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

        services.AddScoped<IApplicationDbContext>(sp => 
                sp.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<IUnitOfWork>(sp => 
                sp.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<ICustomerRepository, CustomerRepository>();

        return services;
    }
}
>>>>>>> 445520db14f862bd97211cc643700f05f88eeb5b
