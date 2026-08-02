using Casia_backend.src.Inventory.Core.Domain.DTOs;

namespace Casia_backend.src.Inventory.Core.Domain.Repositories
{
    public interface ICatogoriesRepository
    {
        Task<IReadOnlyList<CategoryDto>> GetAllCategoriesAsync();
    }
}
