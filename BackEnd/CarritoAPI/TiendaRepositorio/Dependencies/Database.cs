using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tienda.Repositorio.Dependencies
{
    public static class Database
    {
        public static void ConexionBaseDatos(this IServiceCollection services, IConfiguration conf)
        {

            services.AddDbContext<CarritoContext>(options =>
            {
                options.UseSqlServer(conf.GetConnectionString("VIRTUAL_STORE"));
            });

            services.AddScoped(typeof(RepositorioGeneral<>));
        }
    }
}
