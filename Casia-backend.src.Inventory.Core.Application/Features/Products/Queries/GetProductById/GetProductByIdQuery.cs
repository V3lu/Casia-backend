using Casia_backend.src.Shared.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Features.Products.Queries.GetProductsById
{
    public sealed record GetProductByIdQuery(Guid Id) : IQuery;
}
