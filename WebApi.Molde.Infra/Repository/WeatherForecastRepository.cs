using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Molde.Domain.Interfaces.Repository;
using WebApi.Molde.Domain.Models;
using WebApi.Molde.Infra.Context;

namespace WebApi.Molde.Infra.Repository
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private readonly DbSet<WeatherForecast> _dbSet;
        public WeatherForecastRepository(WeatherForecastContext context)
        {
            _dbSet = context.WeatherForecast;
        }

        public async Task SaveWeatherForecastAsync(WeatherForecast weatherForecast)
        {
            await _dbSet.AddAsync(weatherForecast);
        }

        public async Task<IEnumerable<WeatherForecast>> GetWeathersForecastAsync()
        {
            return await _dbSet.ToListAsync();
        }
    }
}