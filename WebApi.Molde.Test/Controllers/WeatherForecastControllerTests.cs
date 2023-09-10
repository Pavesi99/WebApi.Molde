using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Threading.Tasks;
using WebApi.Molde.Api.Controllers;
using WebApi.Molde.Domain.DTOs;
using WebApi.Molde.Domain.Interfaces.Application;
using Xunit;

namespace WebApi.Molde.Test.Controllers
{
    public class WeatherForecastControllerTests
    {
        private readonly MockRepository mockRepository;

        private Mock<ILogger<WeatherForecastController>> mockLogger;
        private Mock<IWeatherForecastService> mockWeatherForecastService;

        public WeatherForecastControllerTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Default);

            this.mockLogger = this.mockRepository.Create<ILogger<WeatherForecastController>>();
            this.mockWeatherForecastService = this.mockRepository.Create<IWeatherForecastService>();
        }

        private WeatherForecastController CreateWeatherForecastController()
        {
            return new WeatherForecastController(
                this.mockLogger.Object,
                this.mockWeatherForecastService.Object);
        }

        [Fact]
        public async Task Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var weatherForecastController = this.CreateWeatherForecastController();

            // Act
            var result = await weatherForecastController.Get();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task Create_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var weatherForecastController = this.CreateWeatherForecastController();
            WeatherForecastDTO weatherForecastDTO = null;

            // Act
            await weatherForecastController.Create(
                weatherForecastDTO);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
