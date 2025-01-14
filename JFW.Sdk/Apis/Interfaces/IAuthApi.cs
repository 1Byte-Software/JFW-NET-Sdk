
using JFW.Sdk.Models.Requests;

namespace JFW.Sdk.Apis;

public interface IAuthApi
{
    Task<object> AuthAsync(AuthenticationRequest request);

    Task<object> AuthPasswordLessWithEmailLinkAsync();

    Task<object> AuthPasswordLessWithEmailCodeAsync();

    Task<object> AuthPasswordLessWithSMSCodeAsync();

    Task<object> RegisterAsync();

    Task<object> ForgotPasswordAsync();
}