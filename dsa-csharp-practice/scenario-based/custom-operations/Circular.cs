using System;
class Circular
{
    Node head;

    //insert
    public void Insert(int d)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            newNode.next = head;
            return;
        }
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
        newNode.next = head;
    }
    //Delete by val
    public void Delete(int d)
    {
        if (head == null)
        {
            return;
        }
        Node curr = head;
        do
        {
            if (head.data == d)
            {
                if (prev != null)
                {
                    prev.next = curr.next; //prev->next val
                }
                //prev==null deleting head
                else
                {
                    Node temp = head;
                    while (temp.next != head)
                    {
                        temp = temp.next; //last node
                    }
                    head = head.next; //head =next val
                    temp.next = head;
                }
                return;
            }
            prev = curr; //shiftinh ahead
            curr = curr.next;


        } while (curr != head);
    }
    public void Display()
    {
        if (head == null)
        {
            return;
        }

        Node temp = head;
        do
        {
            Console.Write(temp.data + " - ");
            temp = temp.next;
        } while (temp != head);

        Console.WriteLine("(HEAD)");
    }
}