using Microsoft.AspNetCore.Mvc;
using WebApi.Molde.Domain.Interfaces.Application;
using WebApi.Molde.Domain.Models;

namespace WebApi.Molde.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IWeatherForecastService _weatherForecastService;

        // 2 - Injetar WeatherForecastService para buscar as informações
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public Task<IEnumerable<WeatherForecast>> Get()
        {
            return _weatherForecastService.GetWeatherForecastAsync();
        }
    }
}