using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Application.Features.Products.Commands.AddProductToStorage;
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
                var result = await addProductCommandHandler.HandleAsync(new AddProductToStorageCommand(new Product { });
                return Ok(result);
            }
            catch (Exception ex)
            {
                return new CommandResponse<ProductDto>({
                    Response
                })
            }
        }
    }
}
