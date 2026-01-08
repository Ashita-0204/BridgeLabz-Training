using System;
class Node
{
    //Node Class
    public string title, director;
    public int year;
    public double rating;
    public Node prev, next;

    public Node(String titl, string direc, int yr, double rate)
    {
        titl = title;
        direc = director;
        yr = year;
        rate = rating;
    }
}
//Method based class
class MovList
{
    Node head, tail;

    //Add Last
    public void AddLast(string t, string direc, int yr, double rate)
    {
        Node node = new Node(titl, direc, yr, rate);
        if (head == null)
        {
            head = tail = Node;
        }
        else
        {
            tail.next = node;
            node.prev = tail;
            tail = node;
        }
    }

    //Remove
    public void Remove(string titl)
    {
        Node temp = head;
        if (temp != null)
        {
            if (temp.title == titl)
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
                    tail = tail.prev;
                }
                return;
            }
            temp = temp.next;
        }
    }

    //update rating
    public void UpdateRating(string titl, double rate)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.title == titl)
            {
                temp.rating = rate;
                return;
            }
            temp = temp.next;
        }
    }

    //Display Forward
    public void DisplayForward()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.title + " directed by " + temp.director + " has a rating " + temp.rating);
            temp = temp.next;
        }
    }

    //Display Reverse
    public void DisplayReverse()
    {
        Node temp = tail;
        while (temp != null)
        {
            Console.WriteLine(temp.title + " directed by " + temp.director + " has a rating " + temp.rating);
            temp = temp.prev;
        }
    }
}


class MovieManagement
{
    public static void Main()
    {
        MovList movie = new MovList();
        movie.AddLast("Rovalio", "H.R.", 2025, 9.5);
        movie.AddLast("Scheduler", "K. Seth", 2022, 8.5);
        movie.DisplayReverse();
    }
}