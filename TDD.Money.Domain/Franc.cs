namespace TDD.MoneyExample.Domain
{
    public class Franc : Money
    {
        public Franc(decimal amount)
        {
            Amount = amount;
        }

        public override Money Times(decimal multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}
