using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
//using Swashbuckle.AspNetCore.Annotations;

namespace CarritoAPI.Controllers
{
    [ApiController, Route("api/products")]
   // [SwaggerTag("Controlador para funciones de productos")]
    public class ProductosController : ControllerBase
    {
        [HttpGet]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> ListarProductos(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }

        [HttpGet("{id}")]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> ConsultarDetalleProducto(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }

        [HttpDelete("{id}")]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> EliminarProducto(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }


        [HttpPut("update")]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> ActualizarProducto(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }

        [HttpPost("register")]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> CrearProductos(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }



    }
}
