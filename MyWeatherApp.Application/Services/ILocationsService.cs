using MyWeatherApp.Domain.Models;

namespace MyWeatherApp.Application.Services
{
    public interface ILocationsService
    {
        public Task<List<City>> GetLocations(string locationName);
    }
}