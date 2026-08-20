using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Domain.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Casia_backend.src.Shared.Queries;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace Casia_backend.src.Inventory.Core.Application.Features.Categories.Quries.GetAllCategories
{
    public class GetAllCategoriesQueryHandler(
        ICatogoriesRepository repository
        ) : IQueryHandler<GetAllCategoriesQuery, QueryResponse<IReadOnlyList<CategoryDto>>>
    {
        public async Task<QueryResponse<IReadOnlyList<CategoryDto>>> HandleAsync(GetAllCategoriesQuery arguemnt)
        {
            // Validation TODO: Validate the query before processing it
            var categories = await repository.GetAllCategoriesAsync();
            return new QueryResponse<IReadOnlyList<CategoryDto>>{ Response = categories};
        }
    }
}
