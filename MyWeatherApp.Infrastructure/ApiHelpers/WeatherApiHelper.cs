using MyWeatherApp.Infrastructure.DTOs;
using Newtonsoft.Json;

namespace MyWeatherApp.Infrastructure.ApiHelpers
{
    /// <summary>
    /// Access Accuweather Api to gather information about weather
    /// </summary>
    public class WeatherApiHelper : IWeatherApiHelper
    {
        // replace with http://dataservice.accuweather.com
        private const string weatherApiBaseAddress = "http://localhost:3000";
        private const string autoCompleteEndpoints = "locations/v1/cities/autocomplete?apikey={0}&q={1}";
        private const string API_KEY = "mock-key";

        public async Task<List<CityDTO>> GetCities(string cityName)
        {
            string url = $"{weatherApiBaseAddress}/{string.Format(autoCompleteEndpoints, API_KEY, cityName)}";

            var cities = await Get<List<CityDTO>>(url);

            return cities;
        }

        private async Task<T?> Get<T> (string url)
        {
            T result;
            using (HttpClient client = new HttpClient())
            {
                var httpResponse = await client.GetAsync(url);
                string json = await httpResponse.Content.ReadAsStringAsync();
                if (json == null)
                {
                    return default;
                }
                result = JsonConvert.DeserializeObject<T>(json);
            }
            return result;
        }
    }
}
