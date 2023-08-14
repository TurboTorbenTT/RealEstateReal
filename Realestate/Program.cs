global using Realestate.Models;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using RealEstate.Application.Services.RealEstateService;
using RealEstate.Infrastructure;
using RealEstate.Infrastructure.Services.RealEstateService;

var builder = WebApplication.CreateBuilder(args);
var infastructureAssembly = typeof(RealEstateQuery).Assembly;
var assembly = Assembly.GetExecutingAssembly();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// N�r en ctrller/service vil injecte irealestate w/e ved apien skal den bruge denne implementation.
// Betyder at hvis du vil lege rundt uden at �ndre noget kan du bare lave en ny RealEstateService kalde den nr 2 og s� bare implementere den her uden at r�re ctrlen.
// Dependency injektion magic
builder.Services.AddScoped<IRealEstateCommand, RealEstateCommand>();
builder.Services.AddScoped<IRealestateQuery, RealEstateQuery>();
builder.Services.AddScoped<IRealEstateRepoService, RealEstateRepos>();
    

#region SQL client
builder.Services.AddDbContext<SqlDb>(
options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSqlConnection")
    , b => b.MigrationsAssembly(assembly.FullName)));
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
