using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Collections.ObjectModel;
using Task2_WPF.Models;
using Task2_WPF.ViewModels;

namespace Task2_WPF
{
    public partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModel;
            VerticesListBox.ItemsSource = new ObservableCollection<Models.Point>();
        }


        private void AddPoint_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(StartXTextBox.Text);
            double y = double.Parse(StartYTextBox.Text);

            ViewModel.Figures.Add(new Models.Point(x, y));
        }

        private void AddLine_Click(object sender, RoutedEventArgs e)
        {
            Models.Point start = VerticesListBox.Items.Cast<Models.Point>().ToList()[0];
            Models.Point end = VerticesListBox.Items.Cast<Models.Point>().ToList()[1];
            ViewModel.Figures.Add(new Line(start, end));
        }


        private void DeleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (FiguresListView.SelectedItem is GeometricFigure selectedFigure)
            {
                ViewModel.Figures.Remove(selectedFigure);
            }
        }

        private void AddVertex_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(StartXTextBox.Text);
            double y = double.Parse(StartYTextBox.Text);

            Models.Point vertex = new Models.Point(x, y);
            (VerticesListBox.ItemsSource as ObservableCollection<Models.Point>).Add(vertex);
        }

        private void RemoveVertex_Click(object sender, RoutedEventArgs e)
        {
            if (VerticesListBox.SelectedItem is Models.Point vertex)
            {
                (VerticesListBox.ItemsSource as ObservableCollection<Models.Point>).Remove(vertex);
            }
        }


        private void AddPolygon_Click(object sender, RoutedEventArgs e)
        {
            List<Models.Point> vertices = VerticesListBox.Items.Cast<Models.Point>().ToList();
            Polygon polygon = new Polygon(vertices);

            ViewModel.Figures.Add(polygon);
        }
        private void AddEllipse_Click(object sender, RoutedEventArgs e)
        {
            double centerX = double.Parse(StartXTextBox.Text);
            double centerY = double.Parse(StartYTextBox.Text);
            double radiusX = double.Parse(EndXTextBox.Text);
            double radiusY = double.Parse(EndYTextBox.Text);

            Ellipse ellipse = new Ellipse(centerX, centerY, radiusX, radiusY);
            ViewModel.Figures.Add(ellipse);
        }

    }
}
