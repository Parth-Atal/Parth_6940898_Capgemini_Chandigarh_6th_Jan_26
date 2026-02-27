using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    internal class BankAccount
    {
        public string Name { get; set; }
        public int Balance { get; set; }

        public void Deposit(int x)
        {
            Console.WriteLine("Depositing...");
            Balance += x;
            Console.WriteLine("Balance: " + Balance);

            Console.WriteLine();
        }

        public void Withdraw(int x)
        {
            Console.WriteLine("Withdrawing....");

            if (x <= Balance)
            {
                Balance -= x;
                Console.WriteLine("Balance: " + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

            Console.WriteLine();
        }
    }

    class SavingsAccount : BankAccount
    {
        float percentage = 6.5f;
        float interest;

        public void Interest()
        {
            interest = (Balance * percentage)/100;
        }

        public void Summary()
        {
            Interest();
            Console.WriteLine("Summary");
            Console.WriteLine("Savings Account");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Balance: " + Balance);
            Console.WriteLine("Interest Percentage: " + percentage);
            Console.WriteLine("Interest: " + interest);
            Console.WriteLine("Total Balance (including interest): " + (Balance + interest));
        }
    }

    class CheckingAccount : BankAccount
    {
        public void Summary()
        {
            Console.WriteLine("Summary");
            Console.WriteLine("Account Type: Checking Account");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
