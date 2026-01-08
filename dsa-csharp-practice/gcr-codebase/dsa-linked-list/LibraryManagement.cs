using System;
class Node
{
    public int id;
    public string title, author, genre;
    public bool availability;
    public Node prev, next;

    public Node(int iD, string Title, string Author, string Genre, bool avail)
    {
        id = iD;
        title = Title;
        author = Author;
        genre = Genre;
        availability = avail;
        next = null;
        prev = null;
    }
}
class Library
{
    //All methods
    Node head, tail;

    //AddLast
    public void AddLast(int iD, string Title, string Author, string Genre)
    {
        Node node = new Node(iD, Title, Author, Genre);
        if (head == null)
        {
            head = tail = node;
        }
        else
        {
            tail.next = node;
            node.prev = tail;
            tail = node;
        }
    }

    //remove
    public void Remove(int iD)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.id == iD)
            {
                if (temp.prev != null)
                {
                    temp.prev.next = temp.next;
                }
                else
                {
                    head = temp.next;
                }
                if (temp.next != null)
                {
                    temp.next.prev = temp.prev;
                }
                else
                {
                    tail = temp.prev;
                }
                return;
            }
            temp = temp.next;
        }
    }

    //Update avail
    public void UpdateAvail(int iD, bool avail)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.id == iD)
            {
                temp.availability = avail;
                return;
            }
            temp = temp.next;
        }
    }
    //diisplay
    public void DisplayForward()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.title + " " + temp.author + " " + temp.availability);
            temp = temp.next;
        }
    }
    public void DisplayReverse()
    {
        Node temp = tail;
        while (temp != null)
        {
            Console.WriteLine(temp.title + " " + temp.author + " " + temp.availability);
            temp = temp.prev;
        }
    }
    public int Count()
    {
        int count = 0;
        Node temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.next;
        }
        return count;
    }

}
class LibraryManagement
{
    public static void Main()
    {
        Library book = new Library();
        book.AddLast(1, "C# Basics", "M.S", "Programming");
        book.AddLast(2, "Kashi", "Benaras", "Tourism");
        book.DisplayForward();
        Console.WriteLine("Total Books: " + book.Count());
    }
}