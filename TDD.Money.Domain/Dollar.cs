namespace TDD.MoneyExample.Domain
{
    public class Dollar : Money
    {
        public Dollar(decimal amount)
        {
            Amount = amount;
        }

        public override Money Times(decimal multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}
