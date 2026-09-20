using Microsoft.Extensions.Configuration;
using Tienda.Negocio.Contratos;
using Tienda.Negocio.DTO;
using Tienda.Negocio.Excepciones;
using Tienda.Negocio.Funciones;
using Tienda.Repositorio;
using Tienda.Repositorio.Modelos;


namespace Tienda.Negocio.Servicios
{
    internal class Autenticacion(RepositorioGeneral<Usuario> user, IConfiguration config) : IAutenticacion
    {

        public async Task<Response<string>> ValidarUsuario(string usuario, string contrasena)
        {
            var query = await user.ConsultarRegistro(x => x.Email == usuario && x.PasswordHash == contrasena);

            if(query != null)
            {
                var token = Utilitarios.GenerarToken(config);

                return new Response<string>{ Exito = true, Mensaje = "Autenticación exitosa", Data = token };
            }
            else
            {
                throw new NoAutorizadoException("Credenciales incorrectas");
            }
        }
    }
}
