using System.Threading.Tasks;
using System.Collections.Generic;
using DotNetCoreMaterialsAndComponents.Domain.Entities;

namespace DotNetCoreMaterialsAndComponents.Domain.Interfaces
{
    public interface IMaterialRepository
    {
         Task<IEnumerable<Material>> GetMaterialsAsync();
         Task<Material> GetByMaterialRefAsync(string? materialRef);
         Task<Material> CreateAsync(Material material);
         Task<Material> UpdateAsync(Material material);
         Task<Material> RemoveAsync(Material material);
    }
}