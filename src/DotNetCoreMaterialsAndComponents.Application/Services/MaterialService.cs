using DotNetCoreMaterialsAndComponents.Domain.Interfaces; 
using DotNetCoreMaterialsAndComponents.Application.Interfaces;
using System.Threading.Tasks;
using DotNetCoreMaterialsAndComponents.Application.DTOs;
using MaterialDomain = DotNetCoreMaterialsAndComponents.Domain.Entities.Material;
using System.Collections.Generic;
using AutoMapper;

namespace DotNetCoreMaterialsAndComponents.Application.Services
{
    public class MaterialService : IMaterialService
    {
        private IMaterialRepository _repository;
        private readonly IMapper _mapper;

        public MaterialService(IMaterialRepository repository, IMapper mapper) {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Material>> GetMaterials()
        {
            return _mapper.Map<IEnumerable<Material>>(await _repository.GetMaterialsAsync());
        }

        public async Task<Material> GetByMaterialRef(string materialRef)
        {
            return _mapper.Map<Material>(await _repository.GetByMaterialRefAsync(materialRef));
        }

        public async Task<Material> Create(Material material)
        {
            return _mapper.Map<Material>(
                await _repository.CreateAsync(_mapper.Map<MaterialDomain>(material)));
        }

        public async Task<Material> Update(Material material)
        {
            return _mapper.Map<Material>(
                await _repository.UpdateAsync(_mapper.Map<MaterialDomain>(material))
            );
        }

        public async Task Remove(Material material)
        {
            await _repository.RemoveAsync(_mapper.Map<MaterialDomain>(material));
        }
    }
}