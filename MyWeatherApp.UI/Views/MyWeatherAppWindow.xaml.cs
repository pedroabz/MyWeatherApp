using MyWeatherApp.UI.ViewModels;
using System.Windows;

namespace MyWeatherApp.UI.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MyWeatherAppWindow : Window
    {
        public MyWeatherAppWindow()
        {
            DataContext = new MyWeatherAppViewModel();
            InitializeComponent();
        }
    }
}
