using Casia_backend.src.Inventory.Core.Domain.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Entities;
using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Infrastructure.Repositories
{
    public sealed class CategoriesRepository(InventoryDbContext dbContext) : ICatogoriesRepository
    {
        public async Task<IReadOnlyList<CategoryDto>> GetAllCategoriesAsync()
        {
            return await dbContext.Categories
                .Select(c => new CategoryDto(c.Id, c.Name, c.Products.ToList()))
                .ToListAsync();
        }
    }
}
