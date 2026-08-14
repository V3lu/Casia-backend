using Casia_backend.src.Inventory.Core.Domain.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Entities;

namespace Casia_backend.src.Inventory.Core.Domain.Repositories
{
    public interface ICatogoriesRepository
    {
        Task<IReadOnlyList<CategoryDto>> GetAllCategoriesAsync();
        Task<Category> GetCategoryById(Guid Id);
        Task<Guid> AddCategoryToStorage(Category Category);
    }
}
