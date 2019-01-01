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
            return new Money(amount + addend.amount, currency);
        }
    }
}
