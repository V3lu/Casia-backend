using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Domain.Entities
{
    public sealed class Category
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public List<Product> Products { get; set; } = [];
    }
}
