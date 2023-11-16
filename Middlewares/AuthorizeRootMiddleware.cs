using DotNetAuthServiceDriver.IOModels.Authorize;
using DotNetAuthServiceDriver.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic;

namespace DotNetAuthServiceDriver.Middlewares;

public class AuthorizeRootMiddleware : BaseAuthorizeMiddleware
{
    
    public AuthorizeRootMiddleware(RequestDelegate next, AuthServiceClient cli) : base(next, cli)
    {
        _middlewareRole = Roles.Root;
    }
}
