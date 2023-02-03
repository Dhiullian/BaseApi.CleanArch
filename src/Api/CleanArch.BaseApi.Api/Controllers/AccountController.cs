using CleanArch.BaseApi.Application.Interfaces.Identity;
using CleanArch.BaseApi.Application.ServiceModel.Auth;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.BaseApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AccountController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("authenticate")]
        public async Task<ActionResult<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request)
        {
            return Ok(await _authService.AuthenticateAsync(request));
        }

        [HttpPost("register")]
        public async Task<ActionResult<RegistrationResponse>> RegisterAsync(RegistrationRequest request)
        {
            return Ok(await _authService.RegisterAsync(request));
        }
    }
}
