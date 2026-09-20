using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tienda.Negocio.Contratos;
using Tienda.Negocio.DTO;

namespace Tienda.API.Controllers
{
    [ApiController, Route("api/auth")]
    public class AuthController(IAutenticacion autenticacion) : ControllerBase
    {
        /// <summary>
        /// Permite a un usuario iniciar sesión en el sistema.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("login")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<ErrorModel>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Response<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var respuesta = await autenticacion.ValidarUsuario(request.Correo, request.Password);

            return Ok(respuesta);
        }
    }
}
