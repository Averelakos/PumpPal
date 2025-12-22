public class UsersEndpoints
{
    public static void MapEndpoints(IEndpointRouteBuilder app)
    {
        app.MapGet("/users", () => "List of users");
    }
}