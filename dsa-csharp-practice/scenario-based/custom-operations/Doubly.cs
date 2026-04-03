using System;
class Doubly
{
    Node head, tail;
    public void InsertLast(int d)
    {
        Node newNode = new Node(d);
        if (head == null)
        {
            head = tail = newNode;
            return;
        }
        tail.next = newNode;
        newNode.prev = tail;
        tail = newNode;
    }

    //Delete by val}
    public void Delete(int d)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.data == d)
            {
                if (temp.prev != null)
                {
                    temp.prev.next = temp.next; //head node to next
                }
                else
                {
                    head = temp.next;
                }
                if (temp.next != null)
                {
                    temp.prev.prev = temp.prev;
                }
                else
                {
                    tail = temp.prev;
                }
            }
            temp = temp.next;
        }
    }

    //display Forward
    public void DisplayForward()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " - ");
            temp = temp.next;
        }
        Console.WriteLine("NULL");
    }

    //display rev
    public void DisplayReverse()
    {
        DNode temp = tail;
        while (temp != null)
        {
            Console.Write(temp.data + " - ");
            temp = temp.prev;
        }
        Console.WriteLine("NULL");
    }
}

