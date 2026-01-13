using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace ANC.Infrastructure.Bases
{
	public class ANCDbContextFactory : IDesignTimeDbContextFactory<ANCDbContext>
	{
		public ANCDbContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<ANCDbContext>();

			// Connection string for design-time migrations
			// Replace with your actual connection string
			optionsBuilder.UseNpgsql("Host=localhost;Database=ANC_DB;Username=postgres;");

			return new ANCDbContext(optionsBuilder.Options);
		}
	}
}
