using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Threading.Tasks;
using ANC.Infrastructure.Interfaces;
using ANC.Infrastructure.Repositories;
using ANC.Application.Services;
using ANC.Application.Interfaces;

namespace ANC.Application.DI
{
	public static class DependencyInjection
	{
		public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddRepository();
			services.AddAutoMapper();
			services.AddServices(configuration);
			services.AddMemoryCache();
		}

		public static void AddRepository(this IServiceCollection services)
		{
			services.AddScoped<IUnitOfWork, UnitOfWork>();
		}

		private static void AddAutoMapper(this IServiceCollection services)
		{
			services.AddAutoMapper(cfg => { cfg.AddMaps(Assembly.GetExecutingAssembly()); });
		}

		public static void AddServices(this IServiceCollection services, IConfiguration configuration)
		{
			// services.AddScoped<IPolicyService, PolicyService>();
			// services.AddScoped<IPolicyTypeService, PolicyTypeService>();
			services.AddScoped<IBranchService, BranchService>();
		}
	}
}

