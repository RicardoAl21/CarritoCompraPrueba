using Tienda.Negocio.DTO;
namespace Tienda.Negocio.Contratos
{
    public interface IAutenticacion
    {
        Task<Response<string>> ValidarUsuario(string usuario, string contrasena);
    }
}
