using Microsoft.EntityFrameworkCore;
using WebApi.Molde.Application.Services;
using WebApi.Molde.Domain.Interfaces.Application;
using WebApi.Molde.Domain.Interfaces.Repository;
using WebApi.Molde.Domain.Interfaces.UnitOfWork;
using WebApi.Molde.Domain.Models;
using WebApi.Molde.Infra.Context;
using WebApi.Molde.Infra.Repository;
using WebApi.Molde.Infra.UnitOfWork;
using Npgsql.EntityFrameworkCore.PostgreSQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Adicionando AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Injeção de serviços
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

//Injeção de repositorios
builder.Services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//Adicionando o banco de dados, nessa caso InMemory
builder.Services.AddDbContext<WeatherForecastContext>(o =>
{
    //Pacote Microsoft.EntityFrameworkCore.InMemory
    o.UseInMemoryDatabase("WeatherForecastDataBase");

    //Pacote Microsoft.EntityFrameworkCore.SqlServer
    //o.UseSqlServer("ConnectionStringAqui");

    //Pacote Npgsql.EntityFrameworkCore.PostgreSQL
    //o.UseNpgsql("ConnectionStringAqui");
});

//Adiciona a rota para verificar se aplicação esta funcionando
builder.Services.AddHealthChecks();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Adiciona a rota para verificar se aplicação esta funcionando
app.UseHealthChecks("/healthy");

app.UseAuthorization();

app.MapControllers();

app.Run();
