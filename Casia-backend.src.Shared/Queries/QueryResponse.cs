using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Shared.Queries
{
    public class QueryResponse<TResponse>()
    {
        public required TResponse Response { get; set; }
        public string? Message { get; set; }
    }
}
