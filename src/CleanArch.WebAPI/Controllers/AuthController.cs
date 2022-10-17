
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CleanArch.Shared.Contracts.Requests;

namespace CleanArch.WebAPI.Controller;

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{

    public AuthController()
    {
        
    }

    [HttpPost("login")]
    public async Task<AuthResult> Login([FromBody] LoginRequest request)
    {
        return new AuthResult();
    }

    [HttpPost("register")]
    public async Task<AuthResult> Register([FromBody] RegistrationRequest request)
    {
        return new AuthResult();
    }

    [HttpPost("logout")]
    public async Task<bool> LogOut()
    {
        return true;
    }

}
