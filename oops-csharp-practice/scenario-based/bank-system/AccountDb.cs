using System;

public class AccountDb
{
    // Stores all accounts
    public Account[] accounts;
    public int count;
    private int nextAccNum;

    // Initialize database
    public AccountDb(int size)
    {
        accounts = new Account[size];
        count = 0;
        nextAccNum = 101;
    }

    // Create new account
    public Account AddAccount(string name, string password, int initialBalance)
    {
        if (count < accounts.Length)
        {
            Account newAccount = new Account(nextAccNum, name, password, initialBalance);
            accounts[count++] = newAccount;
            nextAccNum++;
            return newAccount;
        }

        Console.WriteLine("Database full!");
        return null;
    }

    // Search account by number
    public Account FindAccount(int accNum)
    {
        for (int i = 0; i < count; i++)
        {
            if (accounts[i].accNum == accNum)
                return accounts[i];
        }
        return null;
    }
}
