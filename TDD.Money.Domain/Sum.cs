namespace TDD.MoneyExample.Domain
{
    public class Sum : Expression
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
            throw new System.NotImplementedException();
        }

        public Money Reduce(Bank bank, string to)
        {
            return new Money(augend.Reduce(bank, to).amount 
                                    + addend.Reduce(bank, to).amount, to);
        }
    }
}
