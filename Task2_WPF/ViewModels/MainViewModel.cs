using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_WPF.Models;

namespace Task2_WPF.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<GeometricFigure> Figures { get; set; }

        public MainViewModel()
        {
            Figures = new ObservableCollection<GeometricFigure>()
            {
                new Point(15, 25),
                new Line( new Point(0, 0),  new Point(10, 10)),
                new Polygon(new List<Point> { new Point(1, 1), new Point(1, 3), new Point(3, 1), new Point(3, 3) }),
                new Ellipse(6,6,10,5)

        };
        }
    }
}

