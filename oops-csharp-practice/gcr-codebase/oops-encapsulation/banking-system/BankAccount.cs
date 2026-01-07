public abstract class BankAccount
{
    private string accNum;
    protected int balance;
    public void Deposit(int amount)
    {
        balance += amount;
    }
    public void Withdraw(int amount)
    {
        balance -= amount;
    }
    public abstract int CalculateInterest();
}