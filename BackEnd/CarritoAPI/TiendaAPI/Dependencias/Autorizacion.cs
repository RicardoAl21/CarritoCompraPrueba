using Microsoft.AspNetCore.Authorization;

namespace Tienda.API.Dependencias
{
    public static class Autorizacion
    {
        public static void AuthorizationInjection(this IServiceCollection services)
        {
            var requiresAuth = new AuthorizationPolicyBuilder()
                                  .RequireAuthenticatedUser()
                                  .Build();

            services.AddAuthorizationBuilder().SetFallbackPolicy(requiresAuth);
        }
    }
}
