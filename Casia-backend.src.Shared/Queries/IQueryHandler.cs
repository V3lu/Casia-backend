using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Shared.Queries
{
    public interface IQueryHandler<T, TResponse>
    {
        Task<TResponse> HandleAsync(T arguemnt);
    }
}
