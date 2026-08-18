using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Application.Features.Products.Commands.AddProductToStorage;
using Casia_backend.src.Inventory.Core.Domain.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Entities;
using Casia_backend.src.Inventory.Core.Domain.Requests;
using Casia_backend.src.Shared.Commands;
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
            try
            {
                var product = new Product
                {
                    Id = Guid.Parse(request.Id),
                    Name = request.Name,
                    ExpiryDate = request.ExpiryDate,
                    CategoryId = Guid.Empty
                };

                var result = await addProductCommandHandler.HandleAsync(new AddProductToStorageCommand(product));
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest(new CommandResponse<ProductDto>
                {
                    Response = null
                });
            }
        }

        [HttpPost("addCategory")]
        public async Task<ActionResult<CommandResponse<CategoryDto>>> AddCategory([FromBody] AddCategoryRequest request)
        {
            try
            {
                var category = new Category
                {
                    Id = Guid.Parse(request.Id),
                    Name = request.Name,
                    Products = new List<Product>()
                };
                var result = await addProductCommandHandler.HandleAsync(new AddProductToStorageCommand(category));
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest(new CommandResponse<CategoryDto>
                {
                    Response = null
                });
            }
        }
    }
}
