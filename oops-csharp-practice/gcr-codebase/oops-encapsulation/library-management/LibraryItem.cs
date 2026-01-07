class LibraryItem
{
    protected int itemId;
    protected string title;
    public abstract int GetLoanDuration();
    public void GetItemDetail()
    {
        Console.WriteLine("Title: " + title);
    }

}