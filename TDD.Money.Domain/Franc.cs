namespace TDD.Money.Domain
{
    public class Franc
    {
        private decimal Amount { get; set; }

        public Franc(decimal amount)
        {
            Amount = amount;
        }

        public Franc Times(decimal multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Franc franc = obj as Franc;
            return franc.Amount == Amount;
        }
    }
}
