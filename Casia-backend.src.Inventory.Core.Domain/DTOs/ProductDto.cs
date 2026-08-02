using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.DTOs
{
    public record ProductDto(Guid Id, string Name, DateTime ExpiryDate, Guid CategoryId);
}
