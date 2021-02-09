using System;
using System.Windows;

namespace _1415_lab_03.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(Point origin, int baseLength, int heightLength)
            : base(origin)
        {
            HeightLength = heightLength;
            BaseLength = baseLength;
        }

        public int HeightLength { get; init; }
        public int BaseLength { get; init; }

        public override decimal CalculateArea()
        {
            return (decimal)(HeightLength * BaseLength * .5);
        }
    }
}
