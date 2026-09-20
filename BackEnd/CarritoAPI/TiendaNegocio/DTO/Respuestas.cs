namespace Tienda.Negocio.DTO
{
    public class Response<T>
    {
        public bool Exito { get; set; } = false;
        public string? Mensaje { get; set; } = string.Empty;
        public T? Data { get; set; }
    }

    public class ErrorModel
    {
        public int StatusCode { get; set; }
        public string TraceId { get; set; } = string.Empty;
    }
}
