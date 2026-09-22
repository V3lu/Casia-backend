using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Application.Features.Categories.Commands.AddCategory;
using Casia_backend.src.Inventory.Core.Application.Features.Products.Commands.AddProductToStorage;
using Casia_backend.src.Inventory.Core.Domain.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Entities;
using Casia_backend.src.Inventory.Core.Domain.Requests;
using Casia_backend.src.Shared.Commands;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casia_backend.src.Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryPostController(
        ICommandHandler<AddProductToStorageCommand, CommandResponse<ProductDto>> addProductCommandHandler
        ) : ControllerBase
    {
        [HttpPost("addProduct")]
        public async Task<ActionResult<CommandResponse<ProductDto>>> AddProduct([FromBody] AddProductRequest request)
        {
            var result = await addProductCommandHandler.HandleAsync(new AddProductToStorageCommand(request.Product.Adapt<Product>()));
            return Ok(result);
        }

        [HttpPost("addCategory")]
        public async Task<ActionResult<CommandResponse<CategoryDto>>> AddCategory([FromBody] AddCategoryRequest request)
        {
            var result = await addProductCommandHandler.HandleAsync(new AddCategoryCommandHandler(request.Category.Adapt<Category>()));
            return Ok(result);
        }
    }
}
