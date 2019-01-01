using System.Collections;

namespace TDD.MoneyExample.Domain
{
    public class Bank
    {
        private Hashtable rates = new Hashtable();

        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, decimal rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public decimal GetRate(string from, string to)
        {
            if (from.Equals(to))
                return 1;

            return (decimal)rates[new Pair(from, to)];
        }
    }
}
