public static class WebApplicationExtension
{
    public static void AddServices(this WebApplication webApplication)
    {
        webApplication.Services.AddEndpoints();
    }
    
    private static void AddEndpoints(this IServiceProvider serviceProvider)
    {
        serviceProvider.GetRequiredService<UsersEndpoints>().MapEndpoints();
    }
}