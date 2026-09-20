using Microsoft.AspNetCore.Mvc;
//using Swashbuckle.AspNetCore.Annotations;

namespace CarritoAPI.Controllers
{
    [ApiController, Route("api/orders")]
    //[SwaggerTag("Controlador para funciones de autenticación de usuarios")]
    public class OrdenPagoController : ControllerBase
    {
        [HttpPost]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> FinalizarCompra(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }

        [HttpGet]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> ConsultarHistorialCompras(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }

        [HttpGet("{id}")]
        //[ProducesResponseType(typeof(Respuesta<string>), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(typeof(Respuesta<ErrorModel>), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> ConsultarDetalleCompra(/*[FromBody] LoginRequest request*/)
        {

            return Ok();
        }
    }
}
