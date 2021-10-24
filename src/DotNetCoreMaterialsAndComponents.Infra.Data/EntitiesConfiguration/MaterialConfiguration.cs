using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DotNetCoreMaterialsAndComponents.Domain.Entities;

namespace DotNetCoreMaterialsAndComponents.Infra.Data.EntitiesConfiguration
{
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.HasKey(t => t.MaterialRef);
            builder.Property(p => p.MaterialRef).HasMaxLength(15);
            builder.Property(p => p.Category).IsRequired();
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Brand).IsRequired();
            builder.Property(p => p.Color).IsRequired();
            builder.Property(p => p.Classification).IsRequired();
        }
    }
} 