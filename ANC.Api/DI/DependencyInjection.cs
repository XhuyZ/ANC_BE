using ANC.Infrastructure.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;

namespace ANC.Api.DI
{
	public static class DependencyInjection
	{
		public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.ConfigSwagger();
			services.AddDatabase(configuration);
			services.ConfigRoute();
			services.AddHttpContextAccessor();
			services.AddMemoryCache();
			services.Logger(configuration);
			services.AddCors();
		}


		public static void ConfigRoute(this IServiceCollection services)
		{
			services.Configure<RouteOptions>(options =>
			{
				options.LowercaseUrls = true;
			});
		}

		public static void AddCors(this IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy("CorsPolicy",
									builder =>
									{
										builder.WithOrigins("*")
																 .AllowAnyHeader()
																 .AllowAnyMethod();
									});
			});
		}
		public static void ConfigSwagger(this IServiceCollection services)
		{
			services.AddSwaggerGen(options =>
			{
				options.SwaggerDoc("v1", new OpenApiInfo
				{
					Title = "ANC API",
					Version = "v1",
					Description = "Attendance & Clinic Management API"
				});

				options.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
				{
					Type = SecuritySchemeType.Http,
					Scheme = "bearer",
					BearerFormat = "JWT",
					Description = "JWT Authorization header using the Bearer scheme."
				});

				options.AddSecurityRequirement(document => new OpenApiSecurityRequirement
				{
					[new OpenApiSecuritySchemeReference("bearer", document)] = []
				});
			});
		}

public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<ANCDbContext>(options =>
			{
				options.UseLazyLoadingProxies().UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
			});
		}


		public static void Logger(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddSingleton<ILogger>(sp =>
			{
				var loggerFactory = sp.GetRequiredService<ILoggerFactory>();
				return loggerFactory.CreateLogger("GlobalLogger");
			});
		}
	}
}

