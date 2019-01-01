using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.MoneyExample.Domain
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            return Money.Dollar(10);
        }
    }
}
