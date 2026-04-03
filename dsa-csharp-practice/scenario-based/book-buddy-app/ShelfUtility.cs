using System;
using System.Net;
class ShelfUtitlity : IShelf
{
    private Books[] book;
    private int count;

    public ShelfUtitlity(int size)
    {
        book = new Books[size];
        count = 0;
    }

    //Addn Book
    public void AddBooks()
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();
        Console.Write("Enter author: ");
        string author = Console.ReadLine();
        if (count >= book.Length)
        {
            Console.WriteLine("Library is full");
            return;
        }

        book[count] = title + " is written by " + author;
        count++;
    }

    public void sortBooks()
    {
        if (count == 0)
        {
            Console.WriteLine("No books to sort.");
            return;
        }

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (string.Compare(book[i], book[j], true) > 0)
                {
                    string temp = book[i];
                    book[i] = book[j];
                    book[j] = temp;
                }
            }
        }

        Console.WriteLine("Sorted! ");
    }
    public bool SearchByAuthor()
    {
        Console.Write("Enter author name: ");
        string searchAuthor = Console.ReadLine();

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            string[] parts = book[i].Split(" - ");

            if (parts.Length == 2 && parts[1].Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Found");
                found = true;
            }
        }

        return found;
    }


    public void ExportBooks()
    {
        if (count == 0)
        {
            Console.WriteLine("No books to export.");
            return;
        }

        string[] export = new string[count];

        for (int i = 0; i < count; i++)
        {
            export[i] = book[i];
        }

        Console.WriteLine("\n--- Exported Book List ---");
        foreach (string books in export)
        {
            Console.WriteLine(books);
        }
    }
}

