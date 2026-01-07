public class SavingAccount : BankAccount, ILoanable
{
    public override int CalculateInterest()
    {
        return balance * 0.04;
    }
    public void ApplyForLoan()
    {
        Console.WriteLine("Loan applied");
    }
    public int CalcLoanEligiblity()
    {
        return balance * 6;
    }
}