using Tienda.API.Dependencias;
using Tienda.API.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AuthenticationInjection(builder.Configuration);
builder.Services.AuthorizationInjection();
builder.Services.CORSInjection(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.SwaggerDocInjection();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi().AllowAnonymous();

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "Tienda API v1");
        options.RoutePrefix = "swagger";
    });
}


app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseCors("TiendaOrigins");

app.Use(async (context, next) =>
{
    context.Response.Headers.Append("X-Content-Type-Options", "nosniff");
    context.Response.Headers.Append("X-Frame-Options", "DENY");
    context.Response.Headers.Append("X-XSS-Protection", "1; mode=block");
    await next();
});

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers().RequireAuthorization();

await app.RunAsync();