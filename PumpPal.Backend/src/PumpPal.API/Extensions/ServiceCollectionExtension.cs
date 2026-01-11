public static class ServiceCollectionExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddEndpointsServices();
    }

    private static void AddEndpointsServices(this IServiceCollection services)
    {
       services.AddTransient<UsersEndpoints>();
    }
}