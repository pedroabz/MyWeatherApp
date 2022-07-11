using MyWeatherApp.Domain.Models;
using MyWeatherApp.UI.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MyWeatherApp.UI.ViewModels
{
    public class MyWeatherAppViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _query;

        public string Query
        {
            get { return _query; }
            set {
                _query = value; 
                OnPropertyChanged(nameof(Query));
            }
        }

        private ObservableCollection<City> _cities;

        public ObservableCollection<City> Cities
        {
            get { return _cities; }
            set { _cities = value; }
        }

        public SearchCitiesCommand SearchCitiesCommand { get; set; }

        public MyWeatherAppViewModel(SearchCitiesCommand searchCitiesCommand)
        {
            _cities = new ObservableCollection<City>();
            SearchCitiesCommand = searchCitiesCommand;           
        }

        public void SetCities(List<City> cities)
        {
            _cities.Clear();
            foreach (var city in cities)
            {
                _cities.Add(city);
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
