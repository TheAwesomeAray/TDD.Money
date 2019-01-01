using System;

namespace TDD.MoneyExample.Domain
{
    public abstract class Money
    {
        protected string currency;
        internal decimal amount;

        public Money(decimal amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public abstract Money Times(decimal multiplier);

        public override bool Equals(object obj)
        {
            Money money = obj as Money;
            return money.amount == amount && GetType() == money.GetType();
        }

        public static Dollar Dollar(decimal amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc Franc(decimal amount)
        {
            return new Franc(amount, "CHF");
        }

        public string Currency()
        {
            return currency;
        }
    }
}
