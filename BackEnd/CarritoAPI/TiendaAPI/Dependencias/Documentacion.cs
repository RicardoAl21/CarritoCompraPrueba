using Microsoft.OpenApi;
using System.Reflection;

namespace Tienda.API.Dependencias
{
    public static class Documentacion
    {
        public static void SwaggerDocInjection(this IServiceCollection services)
        {
            services.AddOpenApi( options =>
            {
                options.OpenApiVersion = OpenApiSpecVersion.OpenApi3_0;
                options.AddDocumentTransformer((document, context, cancellationToken) =>
                {
                    // 1. Información del documento
                    document.Info = new OpenApiInfo
                    {
                        Title = "Tienda API",
                        Version = "v1",
                        Description = "API para la gestión de la tienda.",
                        Contact = new OpenApiContact
                        {
                            Name = "Ricardo Cárdenas",
                            Email = "ricardex_21@outlook.com"
                        }
                    };
    
                    // Usar HashSet en lugar de List para cumplir ISet<OpenApiTag>
                    document.Tags = new HashSet<OpenApiTag>
                    {
                        new() {
                            Name = "Auth",
                            Description = "Endpoints para autenticación y autorización de usuarios. Incluye login, registro y gestión de tokens JWT."
                        },
                        new() {
                            Name = "Productos",
                            Description = "Gestión del catálogo de productos. Permite crear, consultar, actualizar y eliminar productos."
                        },
                        new() {
                            Name = "OrdenPago",
                            Description = "Administración de órdenes de compra"
                        },
                        new() {
                            Name = "Carrito",
                            Description = "Gestión del carrito de compras. Agregar, eliminar y consultar items del carrito."
                        }
                    };

                    document.Components ??= new OpenApiComponents();
                    document.Components.SecuritySchemes ??= new Dictionary<string, IOpenApiSecurityScheme>();
                    document.Components.SecuritySchemes.Add("Bearer", new OpenApiSecurityScheme {
                        Type = SecuritySchemeType.Http,
                        Scheme = "bearer",
                        BearerFormat = "JWT",
                        Description = "Formato: Bearer {token}"

                    }); 
                    return Task.CompletedTask;
                });

                // 4. Comentarios XML (Opcional, solo si usas Microsoft.AspNetCore.OpenApi)
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                if (File.Exists(xmlPath))
                {
                    options.AddDocumentTransformer((document, context, ct) =>
                    {
                        return Task.CompletedTask;
                    });
                }

            });
        }
    }
}
