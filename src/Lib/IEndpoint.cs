using Microsoft.AspNetCore.Routing;

namespace FlintSoft.Endpoints;

public interface IEndpoint
{
    void MapEndpoint(IEndpointRouteBuilder app);
}