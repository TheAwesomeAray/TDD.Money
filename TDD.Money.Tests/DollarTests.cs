using TDD.MoneyExample.Domain;
using Xunit;

namespace TDD.MoneyExample.Tests
{
    public class DollarTests
    {
        [Fact]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.Equal(Money.Dollar(10), five.Times(2));
            Assert.Equal(Money.Dollar(15), five.Times(3));
            five = Money.Franc(5);
            Assert.Equal(Money.Franc(10), five.Times(2));
            Assert.Equal(Money.Franc(15), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [Fact]
        public void TestCurrency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency());
            Assert.Equal("CHF", Money.Franc(1).Currency());
        }

        [Fact]
        public void TestAddition()
        {
            Money five = Money.Dollar(5);
            Expression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(10), reduced);
        }

        [Fact]
        public void TestPlusReturnsSum()
        {
            Money five = Money.Dollar(5);
            Expression result = five.Plus(five);
            Sum sum = (Sum)result;
            Assert.Equal(five, sum.augend);
            Assert.Equal(five, sum.addend);
        }

        [Fact]
        public void TestReduceSum()
        {
            Expression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(7), reduced);
        }

        [Fact]
        public void TestReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.Equal(Money.Dollar(1), result);
        }

        [Fact]
        public void TestReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            Assert.Equal(Money.Dollar(1), result);
        }

        [Fact]
        public void TestIdentityRate()
        {
            Assert.Equal(1, new Bank().GetRate("USD", "USD"));
        }

        [Fact]
        public void TestMixedAddition()
        {
            Expression fiveBucks = Money.Dollar(5);
            Expression tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            Assert.Equal(Money.Dollar(10), result);
        }

        [Fact]
        public void TestSumPlusMoney()
        {
            Expression fiveBucks = Money.Dollar(5);
            Expression tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Expression sum = fiveBucks.Plus(tenFrancs).Plus(fiveBucks);
            Money result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            Assert.Equal(Money.Dollar(10), result);
        }

        [Fact]
        public void TestSumTimesMoney()
        {
            Expression fiveBucks = Money.Dollar(5);
            Expression tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Expression sum = fiveBucks.Plus(tenFrancs).Times(2);
            Money result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            Assert.Equal(Money.Dollar(10), result);
        }
    }
}
