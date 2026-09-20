namespace Tienda.Repositorio.Modelos;

public partial class DetalleCompra
{
    public int IdDetalle { get; set; }

    public int IdOrden { get; set; }

    public int IdProducto { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public virtual Ordenes IdOrdenNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
