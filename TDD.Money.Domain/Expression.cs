namespace TDD.MoneyExample.Domain
{
#pragma warning disable IDE1006 // Naming Styles
    public interface Expression
#pragma warning restore IDE1006 // Naming Styles
    {
        Money Reduce(Bank bank, string to);
        Expression Plus(Expression addend);
        Expression Times(decimal multiplier);
    }
}
