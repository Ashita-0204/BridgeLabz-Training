using System;
class Books
{
    //global variables
    string title;
    string author;
    int price;

    public void Display()
    { //method to display
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}
class BookDetail
{
    public static void Main()
    {
        Books book = new Books();
        //inputs
        Console.Write("Enter Title ");
        book.title = Console.ReadLine();
        Console.Write("Enter Author ");
        book.author = Console.ReadLine();
        Console.Write("Enter price ");
        book.price = int.Parse(Console.ReadLine());
        book.Display();
    }



}