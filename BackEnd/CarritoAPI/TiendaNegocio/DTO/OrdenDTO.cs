namespace Tienda.Negocio.DTO
{
    public class OrdenDTO
    {
        public int IdOrden { get; set; } = 0;

        public int IdUsuario { get; set; } = 0;

        public DateTime FechaOrden { get; set; }

        public decimal Total { get; set; } = decimal.Zero;
    }
}
