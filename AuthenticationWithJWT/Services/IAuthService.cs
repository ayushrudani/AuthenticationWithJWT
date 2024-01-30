using AuthenticationWithJWT.Models;

namespace AuthenticationWithJWT.Services
{
	public interface IAuthService
	{
		string GenrateTokenString(LoginUserModel loginUserModel);
		Task<bool> RegisterUser(RegisterUserModel registerUserModel);
		Task<bool> LoginUser(LoginUserModel loginUserModel);
	}
}