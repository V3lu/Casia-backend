using Casia_backend.src.Inventory.Core.Domain.Entities;
using Casia_backend.src.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application.Features.Categories.Commands.AddCategory
{
    public sealed record AddCategoryCommand(Category Category) : ICommand;
}
