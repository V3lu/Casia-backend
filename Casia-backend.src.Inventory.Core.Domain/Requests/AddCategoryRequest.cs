using Casia_backend.src.Inventory.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Domain.Requests
{
    public record AddCategoryRequest(string Id, string Name, List<Product>? Products);
}
