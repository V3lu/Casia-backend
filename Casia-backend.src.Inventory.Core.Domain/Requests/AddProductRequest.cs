using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Domain.Requests
{
    public record AddProductRequest(string Id, string Name, DateTime ExpiryDate);
}
