using System;
class Account
{
    //variables
    public int accNum;
    protected string accHolder;
    private int balance;

    //for private
    public void setBalance(int amt)
    {
        balance = amt;
    }
    public int getBalance()
    {
        return balance;
    }

}

//derived class
class SavingsAccount : Account
{
    public void setHolder(string name)
    {
        accHolder = name;
    }
    public void Display()
    {
        Console.WriteLine("Account Number: " + accNum);
        Console.WriteLine("Account Holder: " + accHolder);
    }

}
class BankManagement
{
    public static void Main()
    {
        SavingsAccount acc = new SavingsAccount();
        acc.accNum = 4562;
        acc.setHolder("Capri-Sun");
        acc.setBalance(8520);
        acc.Display();
        Console.WriteLine("Balance: " + acc.getBalance());
    }
}