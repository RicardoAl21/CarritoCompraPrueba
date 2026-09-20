namespace Tienda.Negocio.DTO
{
    public class DetCompraDTO
    {
        public int IdDetalle { get; set; } = 0;

        public int IdOrden { get; set; } = 0;

        public int IdProducto { get; set; } = 0;

        public int Cantidad { get; set; } = 0;

        public decimal PrecioUnitario { get; set; } = decimal.Zero;

    }
}
