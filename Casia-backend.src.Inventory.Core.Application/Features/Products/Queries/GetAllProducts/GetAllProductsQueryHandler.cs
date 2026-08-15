using Casia_backend.src.Inventory.Core.Domain.Entities;
using Casia_backend.src.Shared.Commands;
using Casia_backend.src.Shared.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Features.Products.Queries.GetAllProducts
{
    public sealed class GetAllProductsQueryHandler() : ICommandHandler<GetAllProductsQuery, QueryResponse<IReadOnlyList<Product>>>
    {
        public Task<QueryResponse<IReadOnlyList<Product>>> HandleAsync(GetAllProductsQuery argument)
        {
            throw new NotImplementedException();
        }
    }
}
