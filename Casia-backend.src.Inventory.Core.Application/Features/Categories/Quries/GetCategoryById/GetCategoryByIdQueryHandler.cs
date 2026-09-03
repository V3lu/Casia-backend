using Casia_backend.src.Inventory.Core.Application.Features.Categories.Quries.GetAllCategories;
using Casia_backend.src.Inventory.Core.Domain.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Casia_backend.src.Shared.Queries;
using Mapster;

namespace Casia_backend.src.Inventory.Core.Application.Features.Categories.Quries.GetCategoryById
{
    public sealed class GetCategoryByIdQueryHandler(
        ICatogoriesRepository catogoriesRepository
        ) : IQueryHandler<GetCategoryByIdQuery, QueryResponse<CategoryDto>>
    {
        public async Task<QueryResponse<CategoryDto>> HandleAsync(GetCategoryByIdQuery query)
        {
            // Validation TODO: Validate the query before processing it
            var category = await catogoriesRepository.GetCategoryById(query.Id);

            //Mapster mapping to categroy dto
            var categoryDto = category.Adapt<CategoryDto>();

            var response = new QueryResponse<CategoryDto>
            {
                Response = categoryDto
            };

            return response;
        }
    }
}
