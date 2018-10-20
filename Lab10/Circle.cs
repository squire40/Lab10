using System;

namespace Lab10
{
    public class Circle
    {
        private double _radius;

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateCirumference()
        {
            return 2 * Radius * Math.PI;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCirumference());
        }

        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        private string FormatNumber(double x)
        {
            return x.ToString("#.00");
        }
    }
}
