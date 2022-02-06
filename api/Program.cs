using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using api.Model;
using api.Data;


// web application setup
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApiContext>(options =>
    options.UseInMemoryDatabase("employeeDB"));

// Add services to the container.
builder.Services.AddScoped<ISeeder, ApiContextSeeder>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// use seeder from service container to seed DB
using (var serviceScope = app.Services.CreateScope())
{
    var services = serviceScope.ServiceProvider;
    var _seeder = services.GetRequiredService<ISeeder>();
    _seeder.SeedData();
}

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
