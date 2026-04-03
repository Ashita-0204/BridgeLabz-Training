using System;
class Book : IReservable, LibraryItem
{
    public override int GetLoanDuration()
    {
        return 18;
    }
    public void ReserveItem()
    {
        Console.WriteLine("Book is reserved");
    }
    public bool CheckAvailability()
    {
        return true;
    }
}