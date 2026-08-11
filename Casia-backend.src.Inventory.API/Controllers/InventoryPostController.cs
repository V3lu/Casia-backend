using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Requests;
using Casia_backend.src.Shared.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casia_backend.src.Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryPostController : ControllerBase
    {
        [HttpPost("Add_Product")]
        public async Task<ActionResult<CommandResponse<ProductDto>>> AddProduct([FromBody] AddProductRequest request)
        {
            //Step 1 : Validate the request

            //Step 2 : Call the service to add the product

            //Step 3 : Return the response

            // For now, we will return a dummy response
        }
    }
}
