using System;
using Microsoft.AspNetCore.Routing;

namespace Lib;

public interface IEndpoint
{
    void MapEndpoint(IEndpointRouteBuilder app);
}