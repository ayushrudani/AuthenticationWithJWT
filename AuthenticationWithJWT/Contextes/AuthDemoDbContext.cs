using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationWithJWT.Contextes
{
	public class AuthDemoDbContext : IdentityDbContext
	{

		public AuthDemoDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
		{

		}

		//public DbSet<ModelName> TableName { get; set; }
	}
}
