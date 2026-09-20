using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CarritoAPI.Controllers
{
   
    [ApiController, Route("api/cart")]
    [SwaggerTag("Controlador para funciones de autenticación de usuarios")]
    public class CarritoController : ControllerBase
    {
        [HttpGet]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> ObtenerCarrito(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }

        [HttpDelete]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> VaciarCarrito(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }

        [HttpPost("items")]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> AgregarProductoCarrito(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }

        [HttpPut("items/{productId}")]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> EditarProductoCarrito(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }

        [HttpDelete("items/{productId}")]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> QuitarProductoCarrito(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }
    }
}
