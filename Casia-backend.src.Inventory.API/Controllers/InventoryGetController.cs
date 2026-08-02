using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casia_backend.src.Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryGetController() : ControllerBase
    {
        [HttpGet("products")]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(new { message = "GetAllProducts endpoint is not yet implemented." });
        }

        [HttpGet("products/{id}")]
        public async Task<IActionResult> GetProductById(string id)
        {
            return Ok(new { message = $"GetProductById endpoint is not yet implemented for id: {id}." });
        }

        [HttpGet("categories")]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(new { message = "GetAllCategories endpoint is not yet implemented." });
        }

        [HttpGet("categories/{id}")]
        public async Task<IActionResult> GetCategoryById(string id)
        {
            return Ok(new { message = $"GetCategoryById endpoint is not yet implemented for id: {id}." });
        }
    }
}
