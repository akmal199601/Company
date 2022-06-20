namespace Web.api.Extensions;

public static class ServiceRegistrations
{
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options => options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
            .AllowAnyOrigin()
            .AllowCredentials()
            .AllowAnyMethod()));

    // public static void ConfigureDbContext(this IServiceCollection services,IConfiguration configuration) => 
    // services.ADdDbContext
}