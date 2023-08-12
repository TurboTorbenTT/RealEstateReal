global using Realestate.Models;
using Realestate.Services.RealEstateService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRealEstateService, RealEstateService>(); // Når en ctrller/service vil injecte irealestate w/e ved apien den skal bruge denne implementation. Betyder at hvis du vil lege rundt uden at ændre noget kan du bare lave en ny RealEstateService kalde den nr 2 og så bare implementere den her uden at røre ctrlen. Dependency injektion magic

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
