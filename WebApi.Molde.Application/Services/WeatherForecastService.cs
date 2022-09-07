using AutoMapper;
using WebApi.Molde.Domain.DTOs;
using WebApi.Molde.Domain.Interfaces.Application;
using WebApi.Molde.Domain.Interfaces.Repository;
using WebApi.Molde.Domain.Models;

namespace WebApi.Molde.Application.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;
        private readonly IMapper _mapper;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository, IMapper mapper)
        {
            _weatherForecastRepository = weatherForecastRepository;
            _mapper = mapper;
        }

        // 1 - Criar Serviço que retorna as previsões
        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync()
        {
            return await _weatherForecastRepository.GetWeathersForecastAsync();
        }

        public async Task CreateWeatherForecastAsync(WeatherForecastDTO weatherForecastDTO)
        {
            var weatherForecast = _mapper.Map<WeatherForecast>(weatherForecastDTO);
            await  _weatherForecastRepository.SaveWeatherForecastAsync(weatherForecast);
        }
    }
}
