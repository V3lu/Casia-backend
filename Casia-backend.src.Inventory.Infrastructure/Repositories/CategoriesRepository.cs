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

        public async Task<Guid> AddCategoryToStorage(Category Category)
        {
            await dbContext.Categories.AddAsync(Category);
            await dbContext.SaveChangesAsync();

            return Category.Id;
        }

        public async Task<Category> GetCategoryById(Guid Id)
        {
            var category = await dbContext.Categories
                .Include(c => c.Products)
                .FirstOrDefaultAsync(c => c.Id == Id);
            return category ?? throw new Exception($"Category with ID {Id} not found.");
        }
    }
}
