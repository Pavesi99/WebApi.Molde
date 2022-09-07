using AutoMapper;
using WebApi.Molde.Domain.DTOs;
using WebApi.Molde.Domain.Models;

namespace WebApi.Molde.Api.AutoMapper
{
    public class DomainToDtoAutoMapperProfile :Profile
    {
        public DomainToDtoAutoMapperProfile()
        {
            CreateMap<WeatherForecastDTO, WeatherForecast>();
        }
    }
}
