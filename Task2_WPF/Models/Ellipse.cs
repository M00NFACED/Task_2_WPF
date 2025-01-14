﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_WPF.Models
{
    public class Ellipse : GeometricFigure
    {
        public double RadiusX { get; set; }
        public double RadiusY { get; set; }
        public double Area { get; }

        public Ellipse(double centerX, double centerY, double radiusX, double radiusY) : base(centerX, centerY)
        {
            RadiusX = radiusX;
            RadiusY = radiusY;
            Area = CalculateArea();
        }

        public override double[] BoundingRectangle
        {
            get
            {
                double left = CenterX - RadiusX;
                double top = CenterY - RadiusY;
                double right = CenterX + RadiusX;
                double bottom = CenterY + RadiusY;

                return new double[] { left, top, right, bottom };
            }
        }

        public override double CalculateArea()
        {
            return Math.PI * RadiusX * RadiusY;
        }
    }
}
