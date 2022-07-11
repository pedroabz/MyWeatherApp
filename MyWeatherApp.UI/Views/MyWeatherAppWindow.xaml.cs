using MyWeatherApp.Infrastructure.ApiHelpers;
using MyWeatherApp.UI.Commands;
using MyWeatherApp.UI.ViewModels;
using System.Windows;

namespace MyWeatherApp.UI.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MyWeatherAppWindow : Window
    {
        public MyWeatherAppWindow(SearchCitiesCommand searchCitiesCommand)
        {
            DataContext = new MyWeatherAppViewModel(searchCitiesCommand);
            InitializeComponent();
        }
    }
}
