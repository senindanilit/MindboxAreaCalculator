
namespace AreaCalculator
{
    public class TriangleUtils : Triangle
    {
        public TriangleUtils(double side1, double side2, double side3) : base(side1, side2, side3)
        {

        }

        public bool IsRightTriangle()
        {
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        public bool IsIsoscelesTriangle()
        {
            return side1 == side2 || side1 == side3 || side2 == side3;
        }
    }
}
