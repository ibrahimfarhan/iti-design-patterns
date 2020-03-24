using ProxyPattern.Entities;
using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard(new BankAccount(1000));
            DebitCard debitCard = new DebitCard(new BankAccount(1000));

            Console.WriteLine("Credit Card\n");

            creditCard.WithdrawMoney(500);
            creditCard.WithdrawMoney(600);

            Console.WriteLine("\nDebit Card\n");

            debitCard.WithdrawMoney(500);
            debitCard.WithdrawMoney(600);

            Console.ReadLine();
        }
    }
}
