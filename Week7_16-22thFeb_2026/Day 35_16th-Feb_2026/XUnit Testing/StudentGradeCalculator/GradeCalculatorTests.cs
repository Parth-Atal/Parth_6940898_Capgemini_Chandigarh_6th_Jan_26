using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StudentGradeCalculator
{
    public class GradeCalculatorTests
    {
        private readonly GradeCalculator calc = new GradeCalculator();

        [Theory]
        [InlineData(95, "A")]
        [InlineData(80, "B")]
        [InlineData(65, "C")]
        [InlineData(40, "F")]

        [Fact]

        public void GetGrade_ReturnsExpectedGrade(int score, string expected)
        {
            // Arrange done via InlineData

            // Act
            var grade = calc.GetGrade(score);

            // Assert
            Assert.Equal(expected, grade);
        }
    }

}
