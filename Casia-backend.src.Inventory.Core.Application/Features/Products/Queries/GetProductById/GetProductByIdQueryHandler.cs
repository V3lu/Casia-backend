using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Application.Features.Products.Queries.GetProductsById;
using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Casia_backend.src.Shared.Queries;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Features.Products.Queries.GetProductById
{
    public sealed class GetProductByIdQueryHandler(
        IProductRepository repository
        ) : IQueryHandler<GetProductByIdQuery, QueryResponse<ProductDto>>
    {
        public async Task<QueryResponse<ProductDto>> HandleAsync(GetProductByIdQuery argument)
        {
            var product = await repository.GetProductById(argument.Id);
            return new QueryResponse<ProductDto>
            {
                Response = product.Adapt<ProductDto>() ?? null
            };
        }
    }
}
