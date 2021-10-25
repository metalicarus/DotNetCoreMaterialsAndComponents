using DotNetCoreMaterialsAndComponents.Domain.Interfaces;
using DotNetCoreMaterialsAndComponents.Infra.Data.Repositories;

namespace DotNetCoreMaterialsAndComponents.CrossCutting.IOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
             services.AddDbContext<ApplicationDbContext>(options => {
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
                new MySqlServerVersion(new Version(8,0,26)),
                x => x.MigrationsAssembly("DotNetCoreMaterialsAndComponents.Infra.Data")
                );
            });

            services.AddScoped<IMaterialRepository, MaterialRepository>();

            return services;
        }
    }
}