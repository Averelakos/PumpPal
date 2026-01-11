/// <summary>
/// Base class for organizing Minimal API endpoints.
/// </summary>
public abstract class EndpointBase
{
    #region Properties
    /// <summary>
    /// Gets the base route for the endpoint group.
    /// </summary>
    protected abstract string BaseRoute { get; }
    /// <summary>
    /// Gets the tag for OpenAPI documentation.
    /// </summary>
    protected abstract string Tag { get; }
    #endregion Properties

    #region Methods
    /// <summary>
    /// mAps all endpoints defined in the derived class.
    /// </summary>
    /// <param name="app"></param>
    public abstract void MapEndpoints();
    /// <summary>
    /// Create a route group with the base route and tag.
    /// </summary>
    /// <param name="groupBuilder"></param>
    /// <returns></returns>
    protected RouteGroupBuilder CreateRouteGroup(RouteGroupBuilder groupBuilder)
    {
        return groupBuilder.MapGroup(BaseRoute).WithTags(Tag);
    }
    #endregion Methods
}