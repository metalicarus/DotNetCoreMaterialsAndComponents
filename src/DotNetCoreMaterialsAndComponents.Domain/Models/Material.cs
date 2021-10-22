using DotNetCoreMaterialsAndComponents.Domain.Enums;

namespace DotNetCoreMaterialsAndComponents.Domain.Models
{
    public class Material
    {
        public Material (string materialRef,
                         Category category,
                         Status status,
                         string description,
                         Brand brand,
                         Color color,
                         Classification classification) 
        {
            MaterialRef = materialRef;
            Category = category;
            Status = status;
            Description = description;
            Brand = brand;
            Color = color; 
            Classification = classification;
        }
        protected Material() { }

        public string MaterialRef {get; private set;}
        public Category Category { get; private set; }
        public Status Status { get; private set; }
        public string Description { get; private set; }
        public Brand Brand { get; private set; }
        public Color Color { get; private set; }
        public Classification Classification { get; private set; }
    }
}