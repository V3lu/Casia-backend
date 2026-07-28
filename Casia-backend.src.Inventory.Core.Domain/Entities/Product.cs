using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required DateTime ExpiryDate { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
