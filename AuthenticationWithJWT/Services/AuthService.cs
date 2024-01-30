using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AuthenticationWithJWT.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticationWithJWT.Services
{
	public class AuthService : IAuthService
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly IConfiguration _configuration;

		public AuthService(UserManager<IdentityUser> userManager, IConfiguration configuration)
		{
			_userManager = userManager;
			_configuration = configuration;
		}
		public async Task<bool> RegisterUser(RegisterUserModel registerUserModel)
		{
			var identityUser = new IdentityUser
			{
				UserName = registerUserModel.UserName,
				Email = registerUserModel.Email
			};
			var result = await _userManager.CreateAsync(identityUser, registerUserModel.Password);

			return result.Succeeded;
		}

		public async Task<bool> LoginUser(LoginUserModel loginUserModel)
		{
			var identityUser = await _userManager.FindByNameAsync(loginUserModel.UserName);
			if (identityUser == null)
			{
				return false;
			}
			return await _userManager.CheckPasswordAsync(identityUser, loginUserModel.Password);
		}

		public string GenrateTokenString(LoginUserModel loginUserModel)
		{
			IEnumerable<System.Security.Claims.Claim> claims = new List<Claim>
			{
				new Claim(ClaimTypes.Name,loginUserModel.UserName),
				new Claim(ClaimTypes.Role,"Admin")
			};

			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:Key").Value));

			SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);

			var securityToken = new JwtSecurityToken(
					claims: claims,
					expires: DateTime.Now.AddHours(1),
					issuer: _configuration.GetSection("Jwt:Issuer").Value,
					audience: _configuration.GetSection("Jwt:Audience").Value,
					signingCredentials: signingCredentials
				);

			string TokenString = new JwtSecurityTokenHandler().WriteToken(securityToken);
			return TokenString;
		}
	}
}
