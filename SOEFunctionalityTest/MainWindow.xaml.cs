﻿using SOEFunctionalityTest.Models;
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
        private MapPointViewModel _mapPointViewModel;
        private MapLineViewModel _mapLineViewModel;
        private ResultsViewModel _resultsViewModel;
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
            DataContext = this._mapPointViewModel;
        }

        private void MapLineButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = _mapLineViewModel;
        }

        private void ResultsButton_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = _resultsViewModel;
        }
    }
}