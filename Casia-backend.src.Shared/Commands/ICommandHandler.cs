using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Shared.Commands
{
    public interface ICommandHandler<T, TResult>
    {
        Task<TResult> HandleAsync(T argument);
    }
}
