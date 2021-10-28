using DotNetCoreMaterialsAndComponents.Domain.Interfaces;
using DotNetCoreMaterialsAndComponents.Infra.Data.Repositories;
using DotNetCoreMaterialsAndComponents.Application.Services;
using DotNetCoreMaterialsAndComponents.Application.Interfaces;
using DotNetCoreMaterialsAndComponents.Application.Mappings;
using DotNetCoreMaterialsAndComponents.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DotNetCoreMaterialsAndComponents.CrossCutting.IOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
             services.AddDbContext<ApplicationDbContext>(options => {
                options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
                new MySqlServerVersion(new Version(8,0,26)),
                    x => x.MigrationsAssembly("DotNetCoreMaterialsAndComponents.Infra.Data")
                );
            });

            services.AddScoped<IMaterialRepository, MaterialRepository>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}