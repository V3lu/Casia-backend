using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Casia_backend.src.Shared.Queries;

namespace Casia_backend.src.Inventory.Core.Application.Features.Categories.Quries.GetAllCategories
{
    public class GetAllCategoriesQueryHandler(
        ICatogoriesRepository repository
        ) : IQueryHandler<GetAllCategoriesQuery, QueryResponse<IReadOnlyList<CategoryDto>>>
    {
        public async Task<QueryResponse<IReadOnlyList<CategoryDto>>> HandleAsync(GetAllCategoriesQuery arguemnt)
        {
            var categories = await repository.GetAllCategories();
            return new QueryResponse<IReadOnlyList<CategoryDto>>{ Response = categories};
        }
    }
}
