namespace TDD.MoneyExample.Domain
{
    public interface Expression
    {
        Money Reduce(Bank bank, string to);
        Expression Plus(Expression addend);

    }
}
