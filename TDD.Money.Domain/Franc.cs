namespace TDD.MoneyExample.Domain
{
    public class Franc : Money
    {
        public Franc(decimal amount, string currency) : base(amount, currency)
        { }

        public override Money Times(decimal multiplier)
        {
            return  Money.Franc(amount * multiplier);
        }
    }
}
