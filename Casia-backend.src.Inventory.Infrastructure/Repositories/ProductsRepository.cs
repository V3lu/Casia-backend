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
        public async Task<IReadOnlyList<Product>> GetAllProductsAsync()
        {
            return await dbContext.Products.ToListAsync();
        }

        public async Task<Guid> AddProductToStorage(Product Product)
        {
            await dbContext.Products.AddAsync(Product);
            await dbContext.SaveChangesAsync();

            return Product.Id;
        }

        public async Task<Product?> GetProductById(Guid Id)
        {
            return await dbContext.Products.FirstOrDefaultAsync(p => p.Id == Id);
        }
    }
}
