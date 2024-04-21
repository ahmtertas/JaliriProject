using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Text.Json.Serialization;
using WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
	.AddControllers()
	.AddJsonOptions(i => i.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve)
	.AddOData(
		configuration =>
		{
			configuration.EnableQueryFeatures();
		}
	);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddCors();

builder.Services.AddDbContext<JaliriContext>(options =>
			{
				options.UseNpgsql(builder.Configuration.GetConnectionString("sqlConnection"), x => x.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
				options.EnableSensitiveDataLogging();
			});

// IoC 
builder.Services.AddApplicationServices();


Log.Logger = new LoggerConfiguration()
	.ReadFrom.Configuration(builder.Configuration).CreateLogger();



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
