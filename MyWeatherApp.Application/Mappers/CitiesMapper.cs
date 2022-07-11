using MyWeatherApp.Domain.Models;
using MyWeatherApp.Infrastructure.DTOs;

namespace MyWeatherApp.Application.Mappers
{
    public static class CitiesMapper
    {
        public static City ToModel(this CityDTO cityDto)
        {
            return new City()
            {
                ExternalKey = cityDto.Key,
                Name = cityDto.LocalizedName,
                Country = cityDto.Country.LocalizedName,
                AdministrativeArea = cityDto.AdministrativeArea.LocalizedName,
            };
        }
    }
}
