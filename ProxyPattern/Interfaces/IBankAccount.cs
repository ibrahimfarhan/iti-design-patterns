using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.Interfaces
{
    public interface IBankAccount
    {
        public bool WithdrawMoney(decimal amount);
    }
}
