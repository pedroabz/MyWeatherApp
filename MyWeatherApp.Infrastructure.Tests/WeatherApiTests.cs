using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWeatherApp.Infrastructure.ApiHelpers;
using System.Threading.Tasks;

namespace MyWeatherApp.Infrastructure.Tests
{
    [TestClass]
    public class WeatherApiTests
    {
        [TestMethod]
        public async Task When_GetCitiesIsCalled_Should_GetCities()
        {
            var weatherApiHelper = new WeatherApiHelper();
            var cities = await weatherApiHelper.GetCities("new york");
            Assert.IsNotNull(cities);
        }
    }
}