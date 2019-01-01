using System;

namespace TDD.MoneyExample.Domain
{
    public class Money : Expression
    {
        protected string currency;
        internal decimal amount;

        public Money(decimal amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money Times(decimal multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public override bool Equals(object obj)
        {
            Money money = obj as Money;
            return money.amount == amount && currency.Equals(money.currency);
        }

        public static Money Dollar(decimal amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(decimal amount)
        {
            return new Money(amount, "CHF");
        }

        public string Currency()
        {
            return currency;
        }

        public override string ToString()
        {
            return $"{amount} {currency}";
        }

        public Expression Plus(Money addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            decimal rate = bank.GetRate(currency, to);
            return new Money(amount / rate, to);
        }

        public Money Reduce(Expression source, string to)
        {
            throw new NotImplementedException();
        }
    }
}
