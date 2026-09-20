namespace Tienda.Repositorio.Modelos;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public bool EsAdmin { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual ICollection<Carrito> Carritos { get; set; } = new List<Carrito>();

    public virtual ICollection<Ordenes> Ordenes { get; set; } = new List<Ordenes>();
}
