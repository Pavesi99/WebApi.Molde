using Microsoft.AspNetCore.Mvc;
using WebApi.Molde.Api.Services;

namespace WebApi.Molde.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly WeatherForecastService _weatherForecastService;

        // 2 - Injetar WeatherForecastService para buscar as informações
        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecastService.GetWeatherForecast();
        }
    }
}