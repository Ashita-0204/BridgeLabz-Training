using System;
class Book
{
    //variable
    public string title;
    public string author;
    public double price;

    // Default constructor
    public Book()
    {
        title = "Jeanie";
        author = "Jean";
        price = 795;
    }

    // Parameterized constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void Display()
    {
        Console.WriteLine(title + "is written by " + author + " for " + price);
    }
}

class BookClass
{
    public static void Main()
    {
        Book book = new Book();
        Book book1 = new Book("Clario", "Clair", 59);

        book.Display();
        book1.Display();
    }
}
