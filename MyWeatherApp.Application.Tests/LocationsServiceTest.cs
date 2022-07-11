using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWeatherApp.Application.Services;
using MyWeatherApp.Infrastructure.ApiHelpers;
using System.Threading.Tasks;

namespace MyWeatherApp.Application.Tests
{
    [TestClass]
    public class LocationsServiceTest
    {
        [TestMethod]
        public async Task Should_ReturnListOfCities_When_CityNameExists()
        {
            IWeatherApiHelper weatherApiHelper = new WeatherApiHelper();
            ILocationsService locationsServices = new LocationsService(weatherApiHelper);
            var locations = await locationsServices.GetLocations("new york");
            Assert.IsNotNull (locations);
        }
    }
}