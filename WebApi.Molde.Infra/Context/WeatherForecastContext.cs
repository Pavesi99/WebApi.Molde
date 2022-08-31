using Microsoft.EntityFrameworkCore;
using WebApi.Molde.Domain.Models;

namespace WebApi.Molde.Infra.Context
{
    public class WeatherForecastContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public WeatherForecastContext(DbContextOptions<WeatherForecastContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        { 
        }

        public DbSet<WeatherForecast> WeatherForecast{ get; set; }
    }
}
