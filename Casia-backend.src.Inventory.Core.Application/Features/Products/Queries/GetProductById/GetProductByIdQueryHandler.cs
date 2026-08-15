using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Application.Features.Products.Queries.GetProductsById;
using Casia_backend.src.Shared.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Features.Products.Queries.GetProductById
{
    public sealed class GetProductByIdQueryHandler() : IQueryHandler<GetProductByIdQuery, QueryResponse<ProductDto>>
    {
        public Task<QueryResponse<ProductDto>> HandleAsync(GetProductByIdQuery arguemnt)
        {
            throw new NotImplementedException();
        }
    }
}
