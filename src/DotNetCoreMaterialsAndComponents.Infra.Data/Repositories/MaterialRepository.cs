using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreMaterialsAndComponents.Domain.Entities;
using DotNetCoreMaterialsAndComponents.Domain.Interfaces;
using DotNetCoreMaterialsAndComponents.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreMaterialsAndComponents.Infra.Data.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        
        private ApplicationDbContext materialContext;

        public MaterialRepository(ApplicationDbContext context)
        {
            this.materialContext = context;
        }

        public async Task<Material> CreateAsync(Material material)
        {
            materialContext.Add(material);
            await materialContext.SaveChangesAsync();
            return material;
        }

        public async Task<Material> GetByMaterialRefAsync(string? materialRef)
        {
            return await materialContext.Materials.FindAsync(materialRef);
        }

        public async Task<IEnumerable<Material>> GetMaterialsAsync()
        {
            return await materialContext.Materials.ToListAsync();
        }

        public async Task<Material> RemoveAsync(Material material)
        {
            materialContext.Remove(material);
            await materialContext.SaveChangesAsync();
            return material;
        }

        public async Task<Material> UpdateAsync(Material material)
        {
            materialContext.Update(material);
            await materialContext.SaveChangesAsync();
            return material;
        }
    }
}