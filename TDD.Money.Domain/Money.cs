namespace TDD.Money.Domain
{
    public class Money
    {
        internal decimal Amount { get; set; }
        
        public override bool Equals(object obj)
        {
            Money money = obj as Money;
            return money.Amount == Amount && GetType() == money.GetType();
        }
    }
}
