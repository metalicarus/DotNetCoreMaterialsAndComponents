using Microsoft.EntityFrameworkCore;
using DotNetCoreMaterialsAndComponents.Domain.Entities;

namespace DotNetCoreMaterialsAndComponents.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) {}

        public DbSet<Material> Materials { get; set;}

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}