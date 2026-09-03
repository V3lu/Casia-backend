using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>> GetAllProductsAsync();
        Task<Guid> AddProductToStorage(Product Product);
        Task<Product?> GetProductById(Guid Id);
    }
}
