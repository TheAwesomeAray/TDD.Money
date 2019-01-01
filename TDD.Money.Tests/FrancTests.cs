using TDD.MoneyExample.Domain;
using Xunit;

namespace TDD.MoneyExample.Tests
{
    public class FrancTests
    {
        [Fact]
        public void testMultiplication()
        {
            Franc five = new Franc(5);
            Assert.Equal(new Franc(10), five.Times(2));
            Assert.Equal(new Franc(15), five.Times(3));
        }
    }
}
