using DotNetAuthServiceDriver.Models;

namespace DotNetAuthServiceDriver.IOModels.Authorize;

public class AuthorizeRequest
{
    public string AccessToken { get; set; }
    public Roles Role { get; set; }

    public AuthorizeRequest(string accessToken, Roles role)
    {
        AccessToken = accessToken;
        Role = role;
    }
}