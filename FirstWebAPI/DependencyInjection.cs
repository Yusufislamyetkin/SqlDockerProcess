using FirstWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FirstWebAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<OrderContext>(opt => opt.UseInMemoryDatabase(databaseName: "InMemoryDb"),
            //                                    ServiceLifetime.Singleton,
            //                                    ServiceLifetime.Singleton);

            services.AddDbContext<FirstAPIContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(FirstAPIContext).Assembly.FullName)), ServiceLifetime.Singleton);

            //Add Repositories
         

            return services;
        }
    }
}
