using System;
using System.Windows;

namespace _1415_lab_03.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(Point origin, int height, int width)
            : base(origin)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; init; }
        public int Width { get; init; }

        public override decimal CalculateArea()
        {
            return (decimal)(Height * Width);
        }
    }
}
