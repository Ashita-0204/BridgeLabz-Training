using System;
// to test the SavingsAccount class
class Banking
{
    public static void Main()
    {
        // Creating a savings account
        SavingsAccount acc = new SavingsAccount
        {
            AccountNumber = 101,
            Balance = 9600,
            InterestRate = 5
        };

        // Displaying account details
        Console.WriteLine("Savings Account Balance: " + acc.Balance);
    }
}
