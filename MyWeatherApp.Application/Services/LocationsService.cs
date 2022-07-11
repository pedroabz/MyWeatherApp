using MyWeatherApp.Application.Mappers;
using MyWeatherApp.Domain.Models;
using MyWeatherApp.Infrastructure.ApiHelpers;

namespace MyWeatherApp.Application.Services
{
    public class LocationsService : ILocationsService
    {
        private IWeatherApiHelper _weatherApiHelper;

        public LocationsService(IWeatherApiHelper weatherApiHelper)
        {
            _weatherApiHelper = weatherApiHelper;
        }
        async Task<List<City>> ILocationsService.GetLocations(string locationName)
        {
            var citiesDto = await _weatherApiHelper.GetCities(locationName);
            return citiesDto.Select(city => city.ToModel()).ToList();
        }
    }
}
