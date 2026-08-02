using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Shared.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Features.Categories.Quries.GetAllCategories
{
    public class GetAllCategoriesQueryHandler() : IQueryHandler<GetAllCategoriesQuery, QueryResponse<IReadOnlyList<CategoryDto>>>
    {
        public Task<QueryResponse<IReadOnlyList<CategoryDto>>> HandleAsync(GetAllCategoriesQuery arguemnt)
        {
            
        }
    }
}
