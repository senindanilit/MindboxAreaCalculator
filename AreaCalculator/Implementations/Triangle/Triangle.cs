using AreaCalculator.Exceptions;



namespace AreaCalculator
{
    public class Triangle : IShape
    {
        protected readonly double side1;
        protected readonly double side2;
        protected readonly double side3;
        protected readonly double[] sides = new double[] { };

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            Array.Sort(sides = new double[] { side1, side2, side3 });
        }

        public double CalculateArea()
        {
            if (!IsRealTriangle())
            {
                throw new ShapeCalculationException("Треугольник с такими параметрами не существует. Выберете другие значения сторон");
            }
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        private bool IsRealTriangle()
        {
            return (sides[0] + sides[1]) > sides[2];
        }

    }
}
