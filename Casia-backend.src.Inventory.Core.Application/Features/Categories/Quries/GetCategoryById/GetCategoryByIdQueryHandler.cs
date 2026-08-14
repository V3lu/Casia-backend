using Casia_backend.src.Inventory.Core.Application.Features.Categories.Quries.GetAllCategories;
using Casia_backend.src.Inventory.Core.Domain.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Casia_backend.src.Shared.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Features.Categories.Quries.GetCategoryById
{
    public sealed class GetCategoryByIdQueryHandler(
        ICatogoriesRepository catogoriesRepository
        ) : IQueryHandler<GetCategoryByIdQuery, QueryResponse<CategoryDto>>
    {
        public async Task<QueryResponse<CategoryDto>> HandleAsync(GetCategoryByIdQuery query)
        {
            var category = await catogoriesRepository.GetCategoryById(query.Id);

            //Mapster mapping to categroy dto
            return category;
        }
    }
}
