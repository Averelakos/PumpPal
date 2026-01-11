public partial class UsersEndpoints: EndpointBase
{
    protected override string BaseRoute => "/api/users";

    protected override string Tag => "Users";

    protected RouteGroupBuilder _groupBuilder;

    public UsersEndpoints(RouteGroupBuilder routeGroupBuilder)
    {
        _groupBuilder = CreateRouteGroup(routeGroupBuilder);
    }

    public override void MapEndpoints()
    {
        _groupBuilder.MapGet("/hello", Hello).WithName("HelloUsers");
    }

    private async Task<IResult> Hello()
    {
        return Results.Ok("Hello from UsersEndpoints!");
    }
}