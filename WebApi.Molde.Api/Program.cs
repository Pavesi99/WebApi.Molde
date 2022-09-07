using Microsoft.EntityFrameworkCore;
using WebApi.Molde.Application.Services;
using WebApi.Molde.Domain.Interfaces.Application;
using WebApi.Molde.Domain.Interfaces.Repository;
using WebApi.Molde.Infra.Context;
using WebApi.Molde.Infra.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Adicionando AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Inje��o de servi�os
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

//Inje��o de repositorios
builder.Services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();

//Adicionando o banco de dados, nessa caso InMemory
builder.Services.AddDbContext<WeatherForecastContext>(o =>
{
    o.UseInMemoryDatabase("WeatherForecastDataBase");
});

//Adiciona a rota para verificar se aplica��o esta funcionando
builder.Services.AddHealthChecks();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Adiciona a rota para verificar se aplica��o esta funcionando
app.UseHealthChecks("/healthy");

app.UseAuthorization();

app.MapControllers();

app.Run();
