using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationWithJWT.Controllers
{
	[Route("Api/[controller]/[action]")]
	[ApiController]
	[Authorize] // to give Authorize to this controller
	public class TestController : Controller
	{
		[HttpGet]
		public string Get()
		{
			return "Auth Done!!!";
		}
	}
}
