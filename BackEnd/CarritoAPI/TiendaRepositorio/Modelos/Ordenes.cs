namespace Tienda.Repositorio.Modelos;

public partial class Ordenes
{
    public int IdOrden { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaOrden { get; set; }

    public decimal Total { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
