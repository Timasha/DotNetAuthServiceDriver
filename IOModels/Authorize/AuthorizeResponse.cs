using DotNetAuthServiceDriver.IOModels.Base;

namespace DotNetAuthServiceDriver.IOModels.Authorize;

public class AuthorizeResponse : BaseResponse
{
    public string Uuid { get; set; }
}