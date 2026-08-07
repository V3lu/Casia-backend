using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Shared.Commands
{
    public class CommandResponse<TResponse>
    {
        public TResponse? Response { get; set; }
    }
}
