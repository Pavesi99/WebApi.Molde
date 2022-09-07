using AutoMapper;
using WebApi.Molde.Domain.DTOs;
using WebApi.Molde.Domain.Models;

namespace WebApi.Molde.Api.AutoMapper
{
    public class DomainToDtoAutoMapper :Profile
    {
        public DomainToDtoAutoMapper()
        {
            CreateMap<WeatherForecastDTO, WeatherForecast>();
        }
    }
}
