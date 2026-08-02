using Casia_backend.src.Inventory.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.DTOs
{
    public record CategoryDto(Guid Id, string Name, List<Product> Products);
}
