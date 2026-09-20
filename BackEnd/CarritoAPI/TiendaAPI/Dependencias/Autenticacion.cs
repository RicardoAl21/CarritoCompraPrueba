using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Tienda.Negocio.DTO;

namespace Tienda.API.Dependencias
{
    public static class Autenticacion
    {
        public static void AuthenticationInjection(this IServiceCollection services, IConfiguration configuration)
        {
            var Issuer = configuration["JWT:Issuer"];
            var Audience = configuration["JWT:Audience"];
            var secretKey = Encoding.UTF8.GetBytes(configuration["JWT:SecretKey"]!);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Issuer,
                    ValidAudience = Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(secretKey)
                };
                options.Events = new JwtBearerEvents
                {
                    OnChallenge = async context =>
                    {
                        context.HandleResponse();

                        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                        context.Response.ContentType = "application/json";

                        await context.Response.WriteAsJsonAsync(new Response<ErrorModel>
                        {
                            Exito = false,
                            Mensaje = "Debe autenticarse para acceder a este recurso.",
                            Data = new ErrorModel()
                            {
                                StatusCode = StatusCodes.Status401Unauthorized,
                                TraceId = string.Empty
                            }
                        });
                    }
                };
            });
        }
    }
}
