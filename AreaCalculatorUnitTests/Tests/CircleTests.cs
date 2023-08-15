using AreaCalculator.Exceptions;
using AreaCalculator;

namespace AreaCalculatorUnitTests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ValidTriangle_ReturnsCorrectArea_1()
        {
            // Arrange
            
            double radius = 1;
            var circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.InRange(area, 3.14, 3.15);
        }

        [Fact]
        public void CalculateArea_ValidTriangle_ReturnsCorrectArea_2()
        {
            // Arrange

            double radius = 5;
            var circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.InRange(area, 78.5, 78.6);
        }

        [Fact]
        public void CalculateArea_ValidTriangle_ReturnsCorrectArea_3()
        {
            // Arrange

            double radius = 5;
            var circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.InRange(area, 78.5, 78.6);
        }

        [Fact]
        public void CalculateArea_ZeroRadius_ThrowsShapeCalculationException()
        {
            // Arrange

            double radius = 0;
            var circle = new Circle(radius);

            // Act & Assert 
            Assert.Throws<ShapeCalculationException>(() => circle.CalculateArea());
        }

        [Fact]
        public void CalculateArea_NegativeRadius_ThrowsShapeCalculationException()
        {
            // Arrange

            double radius = -1;
            var circle = new Circle(radius);

            // Act & Assert 
            Assert.Throws<ShapeCalculationException>(() => circle.CalculateArea());
        }
    }
}
