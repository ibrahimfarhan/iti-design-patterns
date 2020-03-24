using ProxyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.Entities
{
    public class CreditCard : IBankAccount
    {
        public BankAccount BankAccount { get; set; }

        public CreditCard(BankAccount account)
        {
            BankAccount = account;
        }

        public bool WithdrawMoney(decimal amount)
        {
            if (BankAccount.Balance < amount)
            {
                Console.WriteLine("Warning: withdrawn amount exceeded your balance.");
            }

            BankAccount.Balance -= amount;
            Console.WriteLine("Successfully withdrew money. New balance = {0}", BankAccount.Balance);

            return true;
        }
    }
}
