using AreaCalculator.Exceptions;
using System;


namespace AreaCalculator
{
    public class Circle : IShape
    {
        protected readonly double radius;

        public Circle(double radius)
        {

            this.radius = radius;
        }

        public double CalculateArea()
        {
            if (radius <= 0)
            {
                throw new ShapeCalculationException("Радиус круга должен быть больше 0");
            }
            return Math.PI * radius * radius;
        }
    }
}
