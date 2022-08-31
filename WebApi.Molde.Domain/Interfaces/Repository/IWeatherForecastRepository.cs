using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Molde.Domain.Models;

namespace WebApi.Molde.Domain.Interfaces.Repository
{
    public interface IWeatherForecastRepository
    {
        Task SaveWeatherForecastAsync(WeatherForecast weatherForecast);
        Task<IEnumerable<WeatherForecast>> GetWeathersForecastAsync();
    }
}
