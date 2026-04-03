using System;
class Book
{
    //variables
    public string title;
    public string author;
    public double price;
    public bool availability;

    // Parameterized constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        availability = true;
    }

    // Method to borrow book
    public void BorrowBook()
    {
        if (availability)
        {
            availability = false;
            Console.WriteLine("Book borrowed successfully");
        }
        else
        {
            Console.WriteLine("Book is already borrowed");
        }
    }

}
class LibraryManagement
{
    public static void Main()
    {
        Book book = new Book("HomoSapiens", "Jane", 789);
        book.BorrowBook();
    }
}