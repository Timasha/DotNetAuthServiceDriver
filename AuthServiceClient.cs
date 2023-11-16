using System.Net.Http.Json;
using System.Text.Json;
using DotNetAuthServiceDriver.IOModels.Authorize;

namespace DotNetAuthServiceDriver;

public class AuthServiceClient
{
    private RoutesConfig _routesConfig;
    private HttpClient _cli;

    public AuthServiceClient(string authServiceDomain, RoutesConfig routesConfig)
    {
        _routesConfig = routesConfig;
        _cli = new HttpClient()
        {
            BaseAddress = new Uri($"http://{authServiceDomain}")
        };
    }
    public async Task<AuthorizeResponse> AuthorizeAsync(AuthorizeRequest req)
    {
        //TODO: add changing route
        HttpResponseMessage respMsg = await _cli.PostAsJsonAsync(_routesConfig.AuthorizeRoute, req);

        var resp =  JsonSerializer.Deserialize<AuthorizeResponse>(respMsg.Content.ReadAsStream());
        
    }

    public void Authenticate()
    {
        
    }

    public void RegisterUser()
    {
        
    }

    public void RefreshTokens()
    {
        
    }
}