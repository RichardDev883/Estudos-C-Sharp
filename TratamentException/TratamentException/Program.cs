using System;
using TratamentException.Entities;
using System.Globalization;

namespace TratamentException
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter account number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of the account holder: ");
            string holder = Console.ReadLine();
            Console.Write("Enter account withdrawal limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, withdrawLimit);

            Console.WriteLine();
            Console.WriteLine("Let's make a Deposit =)");
            Console.WriteLine("------------");
            Console.Write(" Enter a Deposit amount: ");
            double amountDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(amountDeposit);

            Console.WriteLine();
            Console.WriteLine("Let's make a withdrawal =) ");
            Console.WriteLine("------------");
            Console.Write("Enter the withdrawl amount: ");
            double amountWithdrawal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            account.Withdraw(amountWithdrawal);

            Console.WriteLine("The new Balance is: " + account.Balance);
            Console.ReadLine();
        }
    }
}