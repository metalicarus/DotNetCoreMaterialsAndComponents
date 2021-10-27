using AutoMapper;
using MaterialDomain = DotNetCoreMaterialsAndComponents.Domain.Entities.Material;
using MaterialDTO = DotNetCoreMaterialsAndComponents.Application.DTOs.Material;

namespace DotNetCoreMaterialsAndComponents.Application.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile() => CreateMap<MaterialDomain, MaterialDTO>().ReverseMap();
    }
}