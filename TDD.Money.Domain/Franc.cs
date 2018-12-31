namespace TDD.Money.Domain
{
    public class Franc : Money
    {
        public Franc(decimal amount)
        {
            Amount = amount;
        }

        public Franc Times(decimal multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}
