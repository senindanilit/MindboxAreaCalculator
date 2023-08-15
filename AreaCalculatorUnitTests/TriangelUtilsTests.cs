using AreaCalculator;

namespace AreaCalculatorUnitTests
{
    public class TriangelUtilsTests
    {

        [Fact]
        public void IsRightTriangle_RightTriangle_ReturnsTrue()
        {
            // Arrange
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0;
            var triangle = new TriangleUtils(side1, side2, side3);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRightTriangle);
        }

        [Fact]
        public void IsRightTriangle_NonRightTriangle_ReturnsFalse()
        {
            // Arrange
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 6.0;
            var triangle = new TriangleUtils(side1, side2, side3);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.False(isRightTriangle);
        }


        [Fact]
        public void IsIsoscelesTriangle_RightTriangle_ReturnsTrue()
        {
            // Arrange
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 3.0;
            var triangle = new TriangleUtils(side1, side2, side3);

            // Act
            bool IsIsoscelesTriangle = triangle.IsIsoscelesTriangle();

            // Assert
            Assert.True(IsIsoscelesTriangle);
        }

        [Fact]
        public void IsIsoscelesTriangle_NonRightTriangle_ReturnsFalse()
        {
            // Arrange
            double side1 = 3.0;
            double side2 = 2.0;
            double side3 = 1.9;
            var triangle = new TriangleUtils(side1, side2, side3);

            // Act
            bool IsIsoscelesTriangle = triangle.IsIsoscelesTriangle();

            // Assert
            Assert.False(IsIsoscelesTriangle);
        }
    }
}

