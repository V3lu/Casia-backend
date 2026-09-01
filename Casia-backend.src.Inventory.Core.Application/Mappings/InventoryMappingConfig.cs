using Casia_backend.src.Inventory.Core.Domain.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Mappings
{
    public class InventoryMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Category, CategoryDto>()
                .Map(dest => dest.Products, src => src.Products);
        }
    }
}
