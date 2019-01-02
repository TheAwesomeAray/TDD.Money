namespace TDD.MoneyExample.Domain
{
    public abstract class CanPlus
    {
        protected Expression Plus(Expression augend, Expression addend)
        {
            return new Sum(augend, addend);
        }
    }
}
