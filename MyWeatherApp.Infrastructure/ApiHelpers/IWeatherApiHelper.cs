using MyWeatherApp.Infrastructure.DTOs;

namespace MyWeatherApp.Infrastructure.ApiHelpers
{
    public interface IWeatherApiHelper
    {
        Task<List<CityDTO>> GetCities(string cityName);
    }
}