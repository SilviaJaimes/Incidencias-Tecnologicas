namespace API.Extensions;
public static class AppilicationServiceExtension
{
    public static void ConfigureCore(this IServiceCollection services) =>
    services.AddCors(options => 
    {
        options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
    });
}