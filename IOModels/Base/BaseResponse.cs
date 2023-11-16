namespace DotNetAuthServiceDriver.IOModels.Base;

public abstract class BaseResponse
{
    public string Error { get; set; }
    public ErrorCodes ErrorCode { get; set; }
}