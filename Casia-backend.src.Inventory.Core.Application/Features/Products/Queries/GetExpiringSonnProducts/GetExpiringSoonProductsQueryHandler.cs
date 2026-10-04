using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Casia_backend.src.Shared.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Features.Products.Queries.GetExpiringSonnProducts
{
    public sealed class GetExpiringSoonProductsQueryHandler(
        IProductRepository productRepository
        ) : IQueryHandler<GetExpiringSoonProductsQuery, IReadOnlyList<ProductDto>>
    {
        public async Task<IReadOnlyList<ProductDto>> HandleAsync(GetExpiringSoonProductsQuery arguemnt)
        {
            var products = await productRepository.GetExpiringSoonProductsAsync();

            if (products is null)
            {
                return [];
            }

            return [.. products.Select(p => new ProductDto(
                p.Id,
                p.Name,
                p.ExpiryDate,
                p.CategoryId
            ))];
        }
    }
}
