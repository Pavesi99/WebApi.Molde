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
    public class WeatherForecastRepository : GenericRepository<WeatherForecast>, IWeatherForecastRepository
    {
        private readonly WeatherForecastContext _context;
        public WeatherForecastRepository(WeatherForecastContext context) : base(context)
        {
            _context = context;
        }
    }
}