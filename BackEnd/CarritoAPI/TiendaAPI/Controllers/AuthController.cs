using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CarritoAPI.Controllers
{
    [ApiController, Route("api/auth")]
    [SwaggerTag("Controlador para funciones de autenticación de usuarios")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login"), AllowAnonymous]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> Login(/*[FromBody] LoginRequest request*/)
        {
            
            return Ok();
        }
    }
}
