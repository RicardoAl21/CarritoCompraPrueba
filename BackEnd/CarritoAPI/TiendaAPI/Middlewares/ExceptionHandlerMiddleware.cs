using System.ComponentModel.DataAnnotations;
using Tienda.Negocio.DTO;
using Tienda.Negocio.Excepciones;

namespace Tienda.API.Middlewares
{
    public class ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
    {
        private readonly RequestDelegate _next = next;
        private readonly ILogger<ExceptionHandlerMiddleware> _logger = logger;

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var statusCode = exception switch
            {
                ConflictosException => StatusCodes.Status409Conflict,
                NoEncontradoException => StatusCodes.Status404NotFound,
                NoAutorizadoException => StatusCodes.Status401Unauthorized,
                PeticionFallidaException => StatusCodes.Status400BadRequest,
                ValidationException => StatusCodes.Status400BadRequest,
                _ => StatusCodes.Status500InternalServerError
            };

            _logger.LogError(exception, "Excepción no controlada. Path: {Path}, TraceId: {TraceId}", context.Request.Path, context.TraceIdentifier);

            var response = new Response<ErrorModel>
            {
                Exito = false,
                Mensaje = statusCode == 500 ? "Ocurrió un error interno en el servidor." : exception.Message,
                Data = new ErrorModel
                {
                    StatusCode = statusCode,
                    TraceId = context.TraceIdentifier ?? string.Empty
                }
            };

            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsJsonAsync(response, context.RequestAborted);
        }
    }
}
