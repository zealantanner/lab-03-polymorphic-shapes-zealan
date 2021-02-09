using System;
using System.Windows;
using System.Windows.Media;

namespace _1415_lab_03.Shapes
{
    public abstract class Shape : IShape
    {
        public Point Origin { get; init; }
        public Brush Fill { get; init; }
        public Brush Stroke { get; init; }
        public int StrokeThickness { get; init; }
        public abstract decimal CalculateArea();

        public Shape(Point Origin)
        {
            this.Origin = Origin;
        }

    }
}