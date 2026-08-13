using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Features.Products.Commands.AddProductToStorage
{
    public sealed class AddProductToStorageCommandHandler : ICommandHandler<AddProductToStorageCommand, CommandResponse<ProductDto>>
    {
        public Task<CommandResponse<ProductDto>> HandleAsync(AddProductToStorageCommand argument)
        {
            
        }
    }
}
