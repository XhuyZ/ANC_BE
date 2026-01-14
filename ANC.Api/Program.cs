
using ANC.Api.DI;
using ANC.Api.Middlewares;
using ANC.Application.DI;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration
		.SetBasePath(Directory.GetCurrentDirectory())
		.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
		.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
		.AddEnvironmentVariables();
// okAdd services to the container.okokok
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApplication(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
//builder.WebHost.ConfigureKestrel(options =>
//{
//    options.ListenAnyIP(8080); // Mở HTTP trên cổng 7000 cho tất cả interface
//});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}
else
{
	app.UseDeveloperExceptionPage();
}
app.UseSwagger();
app.UseSwaggerUI(c =>
{
	c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
	c.RoutePrefix = "swagger";
});

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<ExceptionMiddleware>();
app.MapControllers();


app.Run();
