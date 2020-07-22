using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    class Account
    {
        private decimal balance;


        //constructor
        public Account(decimal balance)
        {
            Balance = balance;
        }
        //setting to not accept negative value to the balance
        public decimal Balance
        {
            get { return balance; }
            set 
            {
                if (value >= 0)
                    balance = value;
                else
                   Console.WriteLine("Balance can't accept negative values.");
            }
        }

        //method Credit
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
            else
               Console.WriteLine("amount must be more than 0.");
        }

        //method Debit
        public virtual bool Debit(decimal amount)
        {
            bool withdrawl = true;
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                withdrawl = true;
            }             
            else
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                withdrawl = false;
            }
            return withdrawl;
        }
    }
}
