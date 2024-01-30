using AuthenticationWithJWT.Models;
using AuthenticationWithJWT.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationWithJWT.Controllers
{
	[Route("Api/[controller]/[action]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService _authService;

		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		[HttpPost]
		public async Task<IActionResult> Regiter(RegisterUserModel registerUserModel)
		{
			if (await _authService.RegisterUser(registerUserModel))
			{
				return Ok("Done");
			}
			else
			{
				return BadRequest("Not Found");
			}

		}
		[HttpPost]
		public async Task<IActionResult> Login(LoginUserModel loginUserModel)
		{
			if (await _authService.LoginUser(loginUserModel))
			{
				string Token = _authService.GenrateTokenString(loginUserModel);
				return Ok(Token);
			}
			else
			{
				return BadRequest("Not Found");
			}
		}
	}
}
