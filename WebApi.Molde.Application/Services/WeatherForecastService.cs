using WebApi.Molde.Domain.Interfaces.Application;
using WebApi.Molde.Domain.Interfaces.Repository;
using WebApi.Molde.Domain.Models;

namespace WebApi.Molde.Application.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }

        // 1 - Criar Serviço que retorna as previsões
        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync()
        {
            return await _weatherForecastRepository.GetWeathersForecastAsync();
        }
    }
}
