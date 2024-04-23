using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borovec_OOPBank
{
    public class Bank
    {
        private int _balance;
        public Bank(int balance) 
        {
            _balance = balance;
        }

        //deposit
        public void Deposit(int deposit)
        {
            _balance += deposit;
            Console.WriteLine("Deposit of $" + deposit + " successful...\n");
            CheckBalance();
        }
        //withdrawal
        public void Withdrawal(int withdrawal)
        {
            if (withdrawal > 500)
            {
                Console.WriteLine("Withdrawals are limited to $500 or less, your withdrawal will be adjusted.");
                withdrawal = 500;            
            }
            if (withdrawal <= _balance)
            {
                Console.WriteLine("Withdrawal of $" + withdrawal + " successful...\n");
                _balance -= withdrawal;
            }
            else
            {
                Console.WriteLine("Account Overdrawn. $" + _balance + " has been withdrawn instead.\n");
                _balance = 0;
            }
            CheckBalance();
        }

        //check balance
        public void CheckBalance()
        {
            Console.WriteLine("Current Balance: $" + _balance + "\n");
        }
    }

}
