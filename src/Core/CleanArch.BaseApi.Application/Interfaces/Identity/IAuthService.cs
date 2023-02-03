using CleanArch.BaseApi.Application.ServiceModel.Auth;

namespace CleanArch.BaseApi.Application.Interfaces.Identity
{
    public interface IAuthService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
    }
}
