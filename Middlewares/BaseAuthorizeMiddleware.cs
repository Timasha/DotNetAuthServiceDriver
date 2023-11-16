using DotNetAuthServiceDriver.IOModels.Authorize;
using DotNetAuthServiceDriver.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic;

namespace DotNetAuthServiceDriver.Middlewares;

public abstract class BaseAuthorizeMiddleware
{
    private readonly RequestDelegate next;
    private AuthServiceClient _cli;
    private protected Roles _middlewareRole;
 
    public BaseAuthorizeMiddleware(RequestDelegate next, AuthServiceClient cli)
    {
        this.next = next;
        _cli = cli;
    }
 
    public async Task Invoke(HttpContext httpContext)
    {
        var headerParts =Strings.Split(httpContext.Request.Headers["Authorize"], " ");
        if (headerParts.Length != 2 || headerParts[0] != "Bearer")
        {
            
        }

        AuthorizeResponse resp = await _cli.AuthorizeAsync(new AuthorizeRequest(headerParts[1],_middlewareRole));
        if (resp == null)
        {
            
        }
        await next(httpContext);
    }
}