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
	services.AddSwaggerGen(c =>
	{
		c.SwaggerDoc("v1", new OpenApiInfo
		{
			Title = "ANC API",
			Version = "v1",
			Description = "Attendance & Clinic Management API"
		});

		// // Nếu dùng JWT
		// c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
		// {
		// 	Name = "Authorization",
		// 	Type = SecuritySchemeType.Http,
		// 	Scheme = "bearer",
		// 	BearerFormat = "JWT",
		// 	In = ParameterLocation.Header
		// });

		// c.AddSecurityRequirement(new OpenApiSecurityRequirement
		// {
		// 	{
		// 		new OpenApiSecuritySchemeReference
		// 		{
		// 			Reference = new OpenApiReference
		// 			{
		// 				Type = ReferenceType.SecurityScheme,
		// 				Id = "Bearer"
		// 			}
		// 		},
		// 		Array.Empty<string>()
		// 	}
		// });
	});
}		public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
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

