using System;
class LibraryManagement
{
    //static variable -common for all
    public static string LibraryName = "Classic Library";
    //instance variable
    public string Title;
    public string Author;
    //readonly
    public readonly string ISBN;
    //constructor
    LibraryManagement(string title, string author, string isbn)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }
    // static method
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library: " + LibraryName);
    }
    public void Display()
    {
        if (this is LibraryManagement)
        {
            Console.WriteLine(Title + " is written by " + Author + " with this ISBN code " + ISBN);
        }
    }
    //main method
    public static void Main()
    {
        LibraryManagement book = new LibraryManagement("Sapiens", "Rick Morty", "ISBN896");
        DisplayLibraryName();
        book.Display();
    }

}