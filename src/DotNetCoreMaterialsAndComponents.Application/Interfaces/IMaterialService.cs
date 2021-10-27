using System.Threading.Tasks;
using System.Collections.Generic;
using DotNetCoreMaterialsAndComponents.Application.DTOs;

namespace DotNetCoreMaterialsAndComponents.Application.Interfaces
{
    public interface IMaterialService
    {
        Task<IEnumerable<Material>> GetMaterialAsync();
        Task<Material> GetByMaterialRefAsync(string? materialRef);
        Task<Material> CreateAsync(Material material);
        Task<Material> UpdateAsync(Material material);
        Task RemoveAsync(Material material);
    }
}