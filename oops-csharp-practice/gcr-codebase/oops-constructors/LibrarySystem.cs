using System;
using System.IO.Compression;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;
class Book
{
    //variables
    public string ISBN;
    protected string title;
    private string author;

    //for private variables
    public void setAuthor(string name)
    {
        author = name;
    }
    public void getAuthor()
    {
        return author;
    }
}

//derived class
class EBook : Book
{
    public void setTitle(string str)
    {
        title = str;
    }
    public void Display()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
    }
}
class LibrarySystem
{
    public static void Main()
    {
        EBook book = new EBook();
        book.ISBN = "ISBN123";
        book.setTitle("Clean Code");
        book.setAuthor("Robert Martin");
        book.Display();
        Console.WriteLine("Author: " + book.getAuthor());

    }
}