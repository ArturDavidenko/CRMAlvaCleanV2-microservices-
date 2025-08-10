using AlvaClean.Application.DTOs;
using AlvaClean.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace AuthService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthServiceController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthServiceController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("Login-employeers")]
        public async Task<IActionResult> LogIn([FromBody] LoginEmployeeModel Model)
        {
            try
            {
                var jwtToken = await _authService.LoginEmployee(Model);
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                    expiration = jwtToken.ValidTo
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
