using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    class SavingAccount : Account
    {
        private decimal interestRate;

        //constructor
        public SavingAccount(decimal Balance, decimal interestRate) : base(Balance)
        {
            InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value > 0)
                    interestRate = value;
                else
                    Console.WriteLine("Interest Rate must be greater than 0(zero).");
            }
        }

        //method to calculate interest
        public decimal CalculateInterest() 
        {
            return Balance * InterestRate;
        }
    }
}
