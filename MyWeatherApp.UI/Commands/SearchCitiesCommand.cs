using MyWeatherApp.Application.Services;
using MyWeatherApp.UI.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyWeatherApp.UI.Commands
{
    public class SearchCitiesCommand : ICommand
    {
        private ILocationsService _locationsService;
      
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public SearchCitiesCommand(ILocationsService locationsService)
        {
            _locationsService = locationsService;
        }

        public bool CanExecute(object parameter)
        {
            var viewModel = (MyWeatherAppViewModel)parameter;

            if (string.IsNullOrWhiteSpace(viewModel?.Query))
                return false;
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
