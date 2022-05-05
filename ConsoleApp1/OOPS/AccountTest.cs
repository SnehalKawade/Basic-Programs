using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    class Account
    {
        long accno;
        string accname;
        string acctype;
        int balance;

        public void accept()
        {
            Console.WriteLine("Enter account no,account name,type,balance:");
            accno = Convert.ToInt64(Console.ReadLine());
            accname = Console.ReadLine();
            acctype = Console.ReadLine();
            balance = Convert.ToInt32(Console.ReadLine());
        }
        
        public void withdraw()
        {
            Console.WriteLine("Enter withdraw amount");
            int wamt = Convert.ToInt32(Console.ReadLine());
            if (balance < wamt)
                Console.WriteLine("Insufficient balance");
            else
            {
                balance = balance - wamt;
                Console.WriteLine("Withdraw successfully");
                Console.WriteLine("After withdraw balance "+balance);
            }
        }
        public void deposite()
        {
            Console.WriteLine("Enter deposite amount");
            int damt = Convert.ToInt32(Console.ReadLine());
            balance = balance + damt;
            Console.WriteLine("Deposite successfully after balance is "+balance);
            
        }

    }
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account ac = new Account();
            ac.accept();
            ac.withdraw();
            ac.deposite();
        }
    }
}
