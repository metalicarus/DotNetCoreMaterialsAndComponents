using DotNetCoreMaterialsAndComponents.Domain.Enums;

namespace DotNetCoreMaterialsAndComponents.Application.DTOs
{
    public class Material
    {
        public string MaterialRef {get; set;}
        public Category Category {get; set;}
        public Status Status {get; set;}
        public string Description {get; set;}
    }
}