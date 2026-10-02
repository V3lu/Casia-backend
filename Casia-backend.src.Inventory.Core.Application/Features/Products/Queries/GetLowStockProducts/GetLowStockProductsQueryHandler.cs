using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Casia_backend.src.Shared.Queries;

namespace Casia_backend.src.Inventory.Core.Application.Features.Products.Queries.GetLowStockProducts
{
    public sealed class GetLowStockProductsQueryHandler(
        IProductRepository repository
        ) : IQueryHandler<GetLowStockProductsQuery, QueryResponse<ProductDto>>
    {
        public Task<QueryResponse<ProductDto>> HandleAsync(GetLowStockProductsQuery arguemnt)
        {
            throw new NotImplementedException();
        }
    }
}
