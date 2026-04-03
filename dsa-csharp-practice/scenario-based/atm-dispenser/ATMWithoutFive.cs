// ATM without five hundred note
class ATMWithoutFive : ATM
{
    public ATMWithout500() : base(new int[] { 200, 100, 50, 20, 10, 5, 2, 1 })
    {//referring to parent's base constructor
    }
}
