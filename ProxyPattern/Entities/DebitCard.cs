using ProxyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.Entities
{
    public class DebitCard : IBankAccount
    {
        public BankAccount BankAccount { get; set; }

        public DebitCard(BankAccount account)
        {
            BankAccount = account;
        }

        public bool WithdrawMoney(decimal amount)
        {
            if (BankAccount.Balance < amount)
            {
                Console.WriteLine("Could not withdraw money. Balance is insufficient.");
                return false;
            }

            BankAccount.Balance -= amount;
            Console.WriteLine("Successfully withdrew money. New balance = {0}", BankAccount.Balance);

            return true;
        }
    }
}
