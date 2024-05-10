using SOEFunctionalityTest.Models;
using SOEFunctionalityTest.ViewModels;
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
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MapPointViewModel();
        }

        private void MapPointButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new MapPointViewModel();
        }

        private void MapLineButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new MapLineViewModel();
        }

        private void ResultsButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new ResultsViewModel();
        }
    }
}