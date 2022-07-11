using MyWeatherApp.Application.Services;
using MyWeatherApp.UI.ViewModels;
using System;
using System.Threading.Tasks;

namespace MyWeatherApp.UI.Commands
{
    public class SearchCitiesCommand : System.Windows.Input.ICommand
    {
        private ILocationsService _locationsService;

        public event EventHandler? CanExecuteChanged;

        public SearchCitiesCommand(ILocationsService locationsService)
        {
            _locationsService = locationsService;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            var viewModel = (MyWeatherAppViewModel)parameter;
            var cities = Task.Run(async () => await _locationsService.GetLocations(viewModel.Query)).Result;
            viewModel.SetCities(cities);
        }
    }
}
