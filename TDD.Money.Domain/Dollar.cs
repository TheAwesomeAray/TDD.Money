using System;

namespace TDD.Money.Domain
{
    public class Dollar
    {
        private decimal Amount { get; set; }

        public Dollar(decimal amount)
        {
            Amount = amount;
        }

        public Dollar Times(decimal multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = obj as Dollar;
            return dollar.Amount == Amount;
        }
    }
}
