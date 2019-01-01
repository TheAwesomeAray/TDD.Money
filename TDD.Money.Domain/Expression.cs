namespace TDD.MoneyExample.Domain
{
    public interface Expression
    {
        Money Reduce(string to);
    }
}
