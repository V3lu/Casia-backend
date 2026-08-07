using Casia_backend.src.Inventory.Core.Domain.Entities;
using Casia_backend.src.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Features.Products.Commands.AddProductToStorage
{
    public sealed record AddProductToStorageCommand(Product Product) : ICommand;
}
