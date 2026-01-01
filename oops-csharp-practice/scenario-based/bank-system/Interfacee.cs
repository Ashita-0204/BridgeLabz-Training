using System;

public class Interfacee
{
    private AccountDb database;

    // UI constructor
    public Interfacee(AccountDb db)
    {
        database = db;
    }

    // Main menu
    public void Start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            string choice = Console.ReadLine();

            if (choice == "3") break;

            if (choice == "1") Register();
            else if (choice == "2") Login();
            else Console.WriteLine("Invalid choice!");
        }
    }

    // Register new user
    private void Register()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        Console.Write("Initial Deposit: ");

        int deposit;
        while (!int.TryParse(Console.ReadLine(), out deposit) || deposit < 0) { }

        Account account = database.AddAccount(name, password, deposit);
        if (account != null)
            Console.WriteLine("Account Created. Acc No: " + account.accNum);

        Console.ReadKey();
    }

    // Login flow
    private void Login()
    {
        Console.Write("Account Number: ");
        int accNum;
        while (!int.TryParse(Console.ReadLine(), out accNum)) { }

        Account account = database.FindAccount(accNum);
        if (account == null)
        {
            Console.WriteLine("Account not found");
            Console.ReadKey();
            return;
        }

        Console.Write("Password: ");
        if (account.VerifyPassword(Console.ReadLine()))
            ShowMenu(account);
        else
            Console.WriteLine("Wrong password");

        Console.ReadKey();
    }

    // Logged-in menu
    private void ShowMenu(Account account)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance");
            Console.WriteLine("4. Info");
            Console.WriteLine("5. Logout");
            string choice = Console.ReadLine();

            if (choice == "5") break;

            if (choice == "1")
            {
                int amt;
                while (!int.TryParse(Console.ReadLine(), out amt) || amt <= 0) { }
                account.Deposit(amt);
            }
            else if (choice == "2")
            {
                int amt;
                while (!int.TryParse(Console.ReadLine(), out amt) || amt <= 0) { }
                account.Withdraw(amt);
            }
            else if (choice == "3") account.CheckBalance();
            else if (choice == "4") account.AccountInfo();
            else Console.WriteLine("Invalid choice");

            Console.ReadKey();
        }
    }
}
