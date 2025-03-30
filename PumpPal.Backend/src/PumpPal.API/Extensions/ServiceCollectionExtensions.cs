namespace PumpPal.API;

public static class ServiceCollectionExtension
{
    public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        // services.AddProjects(configuration);
    }

    public static void AddProjects(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddApplicationServices(configuration);
        // services.AddInfrastructureServices(configuration);
    }
}