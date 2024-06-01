using System;
using Task2_WPF.Models;

namespace Task2_WPF.Models
{

    public class Line : GeometricFigure
    {
        public Point[] Vertices { get; set; }
        public double Area { get; }

        public Line(Point start, Point end) : base((start.CenterX + end.CenterX) / 2, (start.CenterY + end.CenterY) / 2)
        {
            Vertices = new Point[] { start, end };
            Area = CalculateArea();
        }

        public override double[] BoundingRectangle
        {
            get
            {
                double left = Math.Min(Vertices[0].CenterX, Vertices[1].CenterX);
                double top = Math.Min(Vertices[0].CenterY, Vertices[1].CenterY);
                double right = Math.Max(Vertices[0].CenterX, Vertices[1].CenterX);
                double bottom = Math.Max(Vertices[0].CenterY, Vertices[1].CenterY);

                return new double[] { left, top, right, bottom };
            }
        }

        public override double CalculateArea()
        {
            return 0;
        }
    }
}
