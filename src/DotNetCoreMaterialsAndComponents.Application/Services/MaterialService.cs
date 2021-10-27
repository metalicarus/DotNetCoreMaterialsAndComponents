using DotNetCoreMaterialsAndComponents.Domain.Interfaces; 
using DotNetCoreMaterialsAndComponents.Application.Interfaces;
using System.Threading.Tasks;
using DotNetCoreMaterialsAndComponents.Application.DTOs;
using System.Collections.Generic;

namespace DotNetCoreMaterialsAndComponents.Application.Services
{
    public class MaterialService : IMaterialService
    {
        private IMaterialRepository _repository;

        public MaterialService(IMaterialRepository repository) {
            _repository = repository;
        }

        public Task<Material> CreateAsync(Material material)
        {
            throw new System.NotImplementedException();
        }

        public Task<Material> GetByMaterialRefAsync(string materialRef)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Material>> GetMaterialAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveAsync(Material material)
        {
            throw new System.NotImplementedException();
        }

        public Task<Material> UpdateAsync(Material material)
        {
            throw new System.NotImplementedException();
        }
    }
}