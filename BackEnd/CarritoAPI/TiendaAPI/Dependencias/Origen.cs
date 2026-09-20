namespace Tienda.API.Dependencias
{
    public static class Origen
    {
        public static void CORSInjection(this IServiceCollection services, IConfiguration config)
        {
            services.AddCors(options =>
            {
                var url = config["CORS:URL"]!;

                options.AddPolicy("TiendaOrigins", builder =>
                {
                    builder.WithOrigins(url)
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });
        }
    }
}
