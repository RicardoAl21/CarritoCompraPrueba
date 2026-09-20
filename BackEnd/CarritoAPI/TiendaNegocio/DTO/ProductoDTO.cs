namespace Tienda.Negocio.DTO
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; } = 0;

        public int IdCategoria { get; set; } = 0;

        public string Nombre { get; set; } = null!;

        public decimal Precio { get; set; } = decimal.Zero;

        public int Stock { get; set; } = 0;

        public bool Activo { get; set; } = false;
    }
}
