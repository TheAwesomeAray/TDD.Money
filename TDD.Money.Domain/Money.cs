using System;

namespace TDD.MoneyExample.Domain
{
    public abstract class Money
    {
        internal decimal Amount { get; set; }

        public abstract Money Times(decimal multiplier);

        public override bool Equals(object obj)
        {
            Money money = obj as Money;
            return money.Amount == Amount && GetType() == money.GetType();
        }

        public static Dollar Dollar(decimal amount)
        {
            return new Dollar(amount);
        }

        public static Franc Franc(decimal amount)
        {
            return new Franc(amount);
        }
    }
}
