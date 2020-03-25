using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.Interfaces
{
    public interface IBankAccount
    {
        bool WithdrawMoney(decimal amount);
    }
}
