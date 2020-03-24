using ProxyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.Entities
{
    public class BankAccount : IBankAccount
    {
        public decimal Balance { get; set; }

        public BankAccount(decimal balance)
        {
            Balance = balance;
        }

        public bool WithdrawMoney(decimal amount)
        {
            if (Balance < amount)
            {
                Balance -= amount;

                return true;
            }

            Console.WriteLine("Could not withdraw money. Balance is insufficient.");
            return false;
        }
    }
}
