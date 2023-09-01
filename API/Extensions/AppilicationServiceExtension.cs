using Dominio.Interfaces;
using Aplicacion.UnitOfWork;
using AspNetCoreRateLimit;

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

    public static void ConfigureRateLimit(this IServiceCollection services)
    {
        services.AddMemoryCache();
        services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
        services.AddInMemoryRateLimiting();
        services.Configure<IpRateLimitOptions>(options =>
        {
            options.EnableEndpointRateLimiting = true;
            options.StackBlockedRequests = false;
            options.HttpStatusCode = 429;
            options.RealIpHeader = "X-Real-IP";
            options.GeneralRules = new List<RateLimitRule>
            {
                new RateLimitRule
                {
                    Endpoint = "*",
                    Period = "10s",
                    Limit = 2
                }
            };
        });
    }

   /*  public static void ConfigureApiVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
        {

        });
    } */
}