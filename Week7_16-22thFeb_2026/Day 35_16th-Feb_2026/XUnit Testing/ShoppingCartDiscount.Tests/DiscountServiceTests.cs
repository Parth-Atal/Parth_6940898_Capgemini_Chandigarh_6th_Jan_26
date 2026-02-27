using ShoppingCartDiscountService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartDiscount.Tests
{
    public class DiscountServiceTests
    {
        private readonly DiscountService service = new DiscountService();

        [Theory]
        [InlineData(120, 108)] // 10% discount
        [InlineData(60, 57)]   // 5% discount
        [InlineData(30, 30)]   // no discount
        public void ApplyDiscount_ReturnsExpectedTotal(decimal total, decimal expected)
        {
            // Arrange done via InlineData

            // Act
            var result = service.ApplyDiscount(total);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ApplyDiscount_ZeroTotal_ReturnsZero()
        {
            // Arrange
            decimal total = 0;

            // Act
            var result = service.ApplyDiscount(total);

            // Assert
            Assert.Equal(0, result);
        }
    }

}
