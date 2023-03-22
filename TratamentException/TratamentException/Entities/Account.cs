using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentException.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit (double amountDeposit)
        {
            Balance += amountDeposit;
        }

        public void Withdraw (double amountWithdrawal)
        {
            Balance -= amountWithdrawal;
        }

        public override string ToString()
        {
            return "Number: " + Number 
                + "\nHolder: " + Holder
                + "\nBalance: " + Balance
                + "\nWithdraw Limit: " + WithdrawLimit;
        }
    }
}
