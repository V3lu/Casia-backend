using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Casia_backend.src.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Features.Products.Commands.AddProductToStorage
{
    public sealed class AddProductToStorageCommandHandler(
        IProductRepository productRepository
        ) : ICommandHandler<AddProductToStorageCommand, CommandResponse<Guid>>
    {
        public async Task<CommandResponse<Guid>> HandleAsync(AddProductToStorageCommand command)
        {
            var productId = await productRepository.AddProductToStorage(command.Product);
            return new CommandResponse<Guid>
            {
                Response = productId
            };
        }
    }
}
