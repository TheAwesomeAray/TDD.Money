namespace TDD.MoneyExample.Domain
{
    public class Sum : CanPlus, Expression
    {
        public Expression augend;
        public Expression addend;

        public Sum(Expression augend, Expression addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Expression Plus(Expression addend)
        {
            return Plus(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            return new Money(augend.Reduce(bank, to).amount 
                                    + addend.Reduce(bank, to).amount, to);
        }

        public Expression Times(decimal multiplier)
        {
            return new Sum(augend.Times(multiplier), addend.Times(multiplier));
        }
    }
}
