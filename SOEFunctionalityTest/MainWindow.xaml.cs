using SOEFunctionalityTest.Models;
using SOEFunctionalityTest.ViewModels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SOEFunctionalityTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MapPointViewModel _mapPointViewModel;
        private MapLineViewModel _mapLineViewModel;
        private ResultsViewModel _resultsViewModel;
        private Button _pointButton;
        private Button _lineButton;
        private Button _resultsButton;
        public MainWindow()
        {
            _mapLineViewModel = new MapLineViewModel();
            _mapPointViewModel = new MapPointViewModel();
            _resultsViewModel = new ResultsViewModel();
            DataContext = _mapPointViewModel;
            InitializeComponent();
        }

        private void MapPointButton_Clicked(object sender, RoutedEventArgs e)
        {
            toggleButtonColor(((Button)sender).Name);
            DataContext = this._mapPointViewModel;
        }

        private void MapLineButton_Clicked(object sender, RoutedEventArgs e)
        {
            toggleButtonColor(((Button)sender).Name);
            DataContext = _mapLineViewModel;
        }

        private void ResultsButton_Clicked(object sender, RoutedEventArgs e)
        {
            toggleButtonColor(((Button)sender).Name);
            DataContext = _resultsViewModel;
        }
        private void toggleButtonColor(string name)
        {
            List<Button> buttons = new List<Button>([(Button)controlsGrid.FindName("MapPointButton"), (Button)controlsGrid.FindName("MapLineButton"), (Button)controlsGrid.FindName("ResultsButton")]);
            foreach (var item in buttons)
            {
                if (item.Name == name)
                {
                    item.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#cfd8ff"));
                }
                else { item.Background = new SolidColorBrush(Colors.White);}
            }
        }
    }
}