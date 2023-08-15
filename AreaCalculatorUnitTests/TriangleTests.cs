using AreaCalculator.Exceptions;
using AreaCalculator;


namespace AreaCalculatorUnitTests
{


    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
        {
            // Arrange
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0;
            var triangle = new Triangle(side1, side2, side3);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.Equal(6.0, area);
        }

        [Fact]
        public void CalculateArea_InvalidTriangle_ThrowsShapeCalculationException()
        {
            // Arrange
            double side1 = 1.0;
            double side2 = 2.0;
            double side3 = 5.0;

            var triangle = new Triangle(side1, side2, side3);
            // Act & Assert
            Assert.Throws<ShapeCalculationException>(() => triangle.CalculateArea());
        }


    }
}
