using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests
{
    using Xunit;

    public class CalculatorTests
    {
        private readonly Calculator calc = new Calculator();

        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5, b = 3;

            // Act
            int result = calc.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            int a = 10, b = 4;

            // Act
            int result = calc.Subtract(a, b);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Arrange
            int a = 7, b = 6;

            // Act
            int result = calc.Multiply(a, b);

            // Assert
            Assert.Equal(42, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange
            int a = 10, b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calc.Divide(a, b));
        }

        [Theory] // Parameterized test
        [InlineData(20, 4, 5)]
        [InlineData(9, 3, 3)]
        public void Divide_ValidNumbers_ReturnsQuotient(int a, int b, double expected)
        {
            // Act
            double result = calc.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }

}
