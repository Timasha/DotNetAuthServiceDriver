namespace DotNetAuthServiceDriver.IOModels.Base;

public enum ErrorCodes
{
    ErrServiceInternalCode,
    SuccessCode,
    ErrServiceNotAvaliableCode,
    
    ErrExpiredAccessTokenCode = 101,
    ErrExpiredRefreshTokenCode,
    ErrExpiredIntermediateTokenCode,
    ErrInvalidPasswordCode,
    ErrInvalidAccessTokenCode,
    ErrInvalidRefreshTokenCode,
    ErrInvalidIntermediateTokenCode,
    ErrUserAlreadyExistsCode,
    ErrUserNotExistsCode,
    ErrInvalidOtpCode,
    ErrRoleHasNoAccessCode,
    ErrRoleAlreadyExistsCode,
    ErrRoleNotExistsCode,
    
    ErrInvalidLoginOrPasswordCode = 201,
    ErrTooShortLoginOrPasswordCode,
    
    ErrInputCode = 301,
    ErrWrongAuthMethodCode
}