using System;
class BankAccount
{
    //static variable
    public static string bankName = "SBI";
    private static int totalAcc = 0;
    //instance variable
    public string accHolderName;
    //readonly variable
    public readonly int accNum;
    //constructor
    public BankAccount(string name, int accNu)
    {
        this.accHolderName = name;
        this.accNum = accNu;
        totalAcc++;
    }
    //static method
    public static void getTotalAcc()
    {
        Console.WriteLine("Tital Accounts " + totalAcc);
    }
    //instance method
    public void Display()
    {
        if (this is BankAccount)
        {
            Console.WriteLine(accHolderName + " with " + accNum);
        }
    }
    //main method
    public static void Main()
    {
        BankAccount acc = new BankAccount("Rhea", 987);
        acc.Display();
        getTotalAcc();
    }


}