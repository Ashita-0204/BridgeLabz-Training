using System;
class Node
{
    public int id;
    public string customer, movie, seat, time;
    public Node next;
    public Node(int Id, string cust, string mov, string Seat, string timee)
    {
        id = Id;
        customer = cust;
        movie = mov;
        seat = Seat;
        time = timee;
        next = null;
    }
}
class Ticket
{
    Node head;

    //Booking
    public void Booking(int Id, string cust, string mov, string Seat, string timee)
    {
        Node node = new Node(Id, cust, mov, Seat, timee);
        if (head == null)
        {
            head = node;
            node.next = head;
            return;
        }
        Node temp = head;
        while (temp.next != head)
        {
            temp = temp.next;
        }
        temp.next = node;
        node.next = head;
    }
    //Display
    public void Display()
    {
        if (head == null)
        {
            return;
        }
        Node temp = head;
        do
        {
            Console.WriteLine(temp.id + " " + temp.customer + " " + temp.movie);
            temp = temp.next;
        } while (temp != head);
    }
    public int Count()
    {
        if (head == null)
        {
            return 0;
        }
        int count = 0;
        Node temp = head;
        do
        {
            count++;
            temp = temp.next;
        } while (temp != head);
        return count;
    }
}
class TicketReservation
{
    public static void Main()
    {
        Ticket ticket = new Ticket();
        ticket.Booking(1, "Kashi", "Touch", "A1", "11AM");
        ticket.Booking(2, "Keshi", "Alike", "B2", "3PM");
        ticket.Display();
        Console.WriteLine("Total Tickets: " + ticket.Count());
    }
}