
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SecondWebAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<OrderContext>(opt => opt.UseInMemoryDatabase(databaseName: "InMemoryDb"),
            //                                    ServiceLifetime.Singleton,
            //                                    ServiceLifetime.Singleton);

            services.AddDbContext<SecondAPIContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(SecondAPIContext).Assembly.FullName)), ServiceLifetime.Singleton);

            //Add Repositories
         

            return services;
        }
    }
}
