using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Domain.Repositories
{
    public interface ICatogoriesRepository
    {
        Task<IReadOnlyList<CategoryDto>> GetAllCategories();
    }
}
