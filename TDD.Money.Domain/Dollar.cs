using System;

namespace TDD.Money.Domain
{
    public class Dollar
    {
        public decimal Amount { get; set; }

        public Dollar(decimal amount)
        {
            Amount = amount;
        }

        public Dollar Times(decimal multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

    }
}
