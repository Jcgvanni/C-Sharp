using System;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(50.00M);
            Account account2 = new Account(25.00M);
            Account account3 = new Account(80.00M);

            Console.WriteLine("account1 balance: {0:C} ",account1.Balance);
            Console.WriteLine("account2 balance: {0:C} ", account2.Balance);
            Console.WriteLine("account3 balance: {0:C} ", account3.Balance);
            Console.WriteLine();

            account1.Debit(25.00M);
            Console.WriteLine("Attempting to debit account1 by $25.00.");
            Console.WriteLine("account1 balance: {0:C} ", account1.Balance);
            Console.WriteLine();
            
            Console.WriteLine("Attempting to debit account2 by $30.00.");
            account2.Debit(30.00M);
            Console.WriteLine("account2 balance: {0:C} ", account2.Balance);
            Console.WriteLine();

            Console.WriteLine("Attempting to debit account3 by $40.00.");
            CheckingAccount account3ck = new CheckingAccount(account3.Balance, 1.00M);
            account3ck.Debit(40.00M);
            Console.WriteLine("{0:C} transaction fee charged.", account3ck.Fee);
            Console.WriteLine("account3 balance: {0:C} ", account3ck.Balance);
            Console.WriteLine();

            account1.Credit(40.00M);
            Console.WriteLine("Crediting $40.00 to account1.");
            Console.WriteLine("account1 balance: {0:C} ", account1.Balance);
            Console.WriteLine();

            account2.Credit(65.00M);
            Console.WriteLine("Crediting $65.00 to account2.");
            Console.WriteLine("account2 balance: {0:C} ", account2.Balance);
            Console.WriteLine();

            Console.WriteLine("Crediting $20.00 to account3.");
            account3ck.Credit(20.00M);
            Console.WriteLine("{0:C} transaction fee charged.", account3ck.Fee);
            Console.WriteLine("account3 balance: {0:C} ", account3ck.Balance);
            Console.WriteLine();

            SavingAccount account2ck = new SavingAccount(account2.Balance, 2.70M);
            account2ck.CalculateInterest();
            account2ck.Credit(account2ck.InterestRate);
            Console.WriteLine("Adding {0:C} interest to account 2.", account2ck.InterestRate);
            Console.WriteLine("New account 2 balance: {0:C}", account2ck.Balance);
            Console.WriteLine();












        }
    }
}
