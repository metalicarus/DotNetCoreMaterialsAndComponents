using System.Threading.Tasks;
using System.Collections.Generic;
using DotNetCoreMaterialsAndComponents.Application.DTOs;

namespace DotNetCoreMaterialsAndComponents.Application.Interfaces
{
    public interface IMaterialService
    {
        Task<IEnumerable<Material>> GetMaterials();
        Task<Material> GetByMaterialRef(string? materialRef);
        Task<Material> Create(Material material);
        Task<Material> Update(Material material);
        Task Remove(Material material);
    }
}