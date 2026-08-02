using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Entities;
using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Infrastructure.Repositories
{
    public sealed class ProductsRepository(InventoryDbContext dbContext) : IProductRepository
    {
        public Task<IReadOnlyList<ProductDto>> GetAllProductsAsync()
        {
            return dbContext.Products
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    ExpiryDate = p.ExpiryDate,
                    CategoryId = p.CategoryId
                })
                .ToListAsync();
        }
    }
}
