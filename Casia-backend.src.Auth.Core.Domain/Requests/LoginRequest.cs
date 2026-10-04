using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Auth.Core.Domain.Requests
{
    public sealed record LoginRequest(string Username, string Password);
}
