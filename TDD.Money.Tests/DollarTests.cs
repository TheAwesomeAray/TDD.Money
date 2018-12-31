using System;
using TDD.Money.Domain;
using Xunit;

namespace TDD.Money.Tests
{
    public class DollarTests
    {
        [Fact]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.Equal(10, product.Amount);
            product = five.Times(3);
            Assert.Equal(15, product.Amount);

        }
    }
}
