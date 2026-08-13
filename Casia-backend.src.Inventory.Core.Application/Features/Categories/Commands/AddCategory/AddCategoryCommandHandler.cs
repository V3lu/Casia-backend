using Casia_backend.src.Inventory.Core.Domain.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Casia_backend.src.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Features.Categories.Commands.AddCategory
{
    public sealed class AddCategoryCommandHandler(
        ICatogoriesRepository catogoriesRepository
        ) : ICommandHandler<AddCategoryCommand, CommandResponse<CategoryDto>>
    {
        public async Task<CommandResponse<CategoryDto>> HandleAsync(AddCategoryCommand command)
        {
            var category = await catogoriesRepository.AddCategoryToStorage(command.Category);
            var categoryDto = new CategoryDto
            (
                Id: command.Category.Id,
                Name: command.Category.Name,
                Products: command.Category.Products
            );
            return new CommandResponse<CategoryDto>
            {
                Response = categoryDto
            };
        }
    }
}
