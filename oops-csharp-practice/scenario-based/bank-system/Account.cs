using System;

public class Account
{
    // Public account details
    public int accNum;
    public string name;

    // Private security-related fields
    private string password;
    private int balance;

    // Constructor to initialize account
    public Account(int accNumber, string Name, string pass, int initialBalance)
    {
        accNum = accNumber;
        name = Name;
        password = pass;
        balance = initialBalance;
    }

    // Password verification
    public bool VerifyPassword(string pass)
    {
        return password == pass;
    }

    // Deposit money
    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Amount deposited: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount!");
        }
    }

    // Withdraw money
    public void Withdraw(int amount)
    {
        if (amount <= balance && amount > 0)
        {
            balance -= amount;
            Console.WriteLine("Amount withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount!");
        }
    }

    // Display balance
    public void CheckBalance()
    {
        Console.WriteLine("Current balance: " + balance);
    }

    // Display account info
    public void AccountInfo()
    {
        Console.WriteLine("Account Number: " + accNum);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Balance: " + balance);
    }
}
