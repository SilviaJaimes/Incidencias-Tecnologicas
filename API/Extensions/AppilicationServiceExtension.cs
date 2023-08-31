using Dominio.Interfaces;
using Aplicacion.UnitOfWork;

namespace API.Extensions;
public static class AppilicationServiceExtension
{
    public static void ConfigureCors(this IServiceCollection services) =>
    services.AddCors(options => 
    {
        options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
    });

    public static void AddAplicacionServices(this IServiceCollection services)
    {
        //Services.AddScoped<IpaisInterface,PaisRepository>();
        //Services.AddScoped<ITipoPersona,TipoPeronsaRepository>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}