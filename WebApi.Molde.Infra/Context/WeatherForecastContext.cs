using Microsoft.EntityFrameworkCore;
using WebApi.Molde.Domain.Models;
using WebApi.Molde.Infra.Mapping;

namespace WebApi.Molde.Infra.Context
{
    public class WeatherForecastContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecast { get; set; }

        public WeatherForecastContext(DbContextOptions<WeatherForecastContext> options) : base(options)
        { 
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WeatherForecastMap());
        }
    }
}
