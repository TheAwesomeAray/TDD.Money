namespace TDD.Money.Domain
{
    public class Dollar : Money
    {
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
