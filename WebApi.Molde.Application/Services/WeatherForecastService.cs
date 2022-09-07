using AutoMapper;
using WebApi.Molde.Domain.DTOs;
using WebApi.Molde.Domain.Interfaces.Application;
using WebApi.Molde.Domain.Interfaces.Repository;
using WebApi.Molde.Domain.Interfaces.UnitOfWork;
using WebApi.Molde.Domain.Models;

namespace WebApi.Molde.Application.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IWeatherForecastRepository _weatherForecastRepository;
        public WeatherForecastService(IUnitOfWork unitOfWork, IMapper mapper, IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // 1 - Criar Serviço que retorna as previsões
        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync()
        {
            return await _weatherForecastRepository.GetAllAync();
        }

        public async Task CreateWeatherForecastAsync(WeatherForecastDTO weatherForecastDTO)
        {
            var weatherForecast = _mapper.Map<WeatherForecast>(weatherForecastDTO);
            await _weatherForecastRepository.InsertAsync(weatherForecast);
            _unitOfWork.Save();
        }
    }
}
