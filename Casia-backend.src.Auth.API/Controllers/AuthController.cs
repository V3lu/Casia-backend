using Casia_backend.src.Auth.Core.Domain.Requests;
using Casia_backend.src.Shared.Commands;
using Casia_backend.src.Shared.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casia_backend.src.Auth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class AuthController() : ControllerBase
    {
        [HttpPost("login")]
        public async Task<ActionResult<CommandResponse<Guid>>> Login([FromBody] LoginRequest request)
        {
            return Ok(new { Token = token });
        }
    }
}
