using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Domain.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Entities;
using Mapster;

namespace Casia_backend.src.Inventory.Core.Application.Mappings
{
    public class InventoryMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Category, CategoryDto>()
                .Map(dest => dest.Products, src => src.Products);

            config.NewConfig<Product, ProductDto>()
                .Map(dest => dest.CategoryId, src => src.CategoryId);
        }
    }
}
