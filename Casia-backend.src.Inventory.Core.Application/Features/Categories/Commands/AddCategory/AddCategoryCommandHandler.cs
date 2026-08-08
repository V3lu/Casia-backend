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
        public async Task<CommandResponse<CategoryDto>> HandleAsync(AddCategoryCommand argument)
        {
            var category = await catogoriesRepository.AddCategoryAsync(argument.Name, argument.Description);
            var categoryDto = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };
            return new CommandResponse<CategoryDto>(categoryDto);
        }
    }
}
