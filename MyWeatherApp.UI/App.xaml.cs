using Microsoft.Extensions.DependencyInjection;
using MyWeatherApp.Application.Services;
using MyWeatherApp.Infrastructure.ApiHelpers;
using MyWeatherApp.UI.Commands;
using MyWeatherApp.UI.Views;
using System.Windows;

namespace MyWeatherApp.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IWeatherApiHelper, WeatherApiHelper>();
            services.AddSingleton<ILocationsService, LocationsService>();
            services.AddSingleton<SearchCitiesCommand>();
            services.AddSingleton<MyWeatherAppWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MyWeatherAppWindow>();
            mainWindow.Show();
        }
    }
}
