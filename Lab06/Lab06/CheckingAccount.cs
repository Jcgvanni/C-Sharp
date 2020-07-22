using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    class CheckingAccount : Account
    {
        private decimal fee;

        //constructor
        public CheckingAccount(decimal Balance, decimal fee) : base(Balance)
        {
            Fee = fee;

        }

        public decimal Fee
        {
            get { return fee; }
            set 
            {
                if (value > 0)
                    fee = value;
                else
                   Console.WriteLine("Fee cannot be zero or less.");
            }
        }

        //redefine method credit
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= Fee;
        }

        //redefine method debit
        public override bool Debit(decimal amount)
        {
           if (base.Debit(amount))
           {
                Balance -= Fee;
                return true;
           }
            return false;
        }
    }
}
