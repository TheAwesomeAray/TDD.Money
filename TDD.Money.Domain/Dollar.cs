namespace TDD.MoneyExample.Domain
{
    public class Dollar : Money
    {
        public Dollar(decimal amount, string currency) : base (amount, currency)
        { }

        public override Money Times(decimal multiplier)
        {
            return Money.Dollar(amount * multiplier);
        }
    }
}
