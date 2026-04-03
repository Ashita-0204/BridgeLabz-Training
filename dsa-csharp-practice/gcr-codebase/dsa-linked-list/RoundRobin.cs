using System;
class Node
{
    public int id, burst, remaining;
    public Node next;
    public Node(int iD, int Burst, int remain)
    {
        id = iD;
        burst = Burst;
        remaining = remain;
        next = null;
    }
}

class Robin
{
    Node head;
    //Add
    public void AddProcess(int iD, int Burst)
    {
        Node node = new Node(iD, Burst, remain);
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

    //execute
    public void Execute(int quantam)
    {
        Node temp = head;
        while (head != null)
        {
            if (temp.remaining > quantam)
            {
                temp.remaining -= quantam;
            }
            else
            {
                Console.WriteLine("Process is completed");
                Remove(temp.id);
            }
            temp = temp.next;
            if (temp == null)
            {
                break;
            }
        }
    }
    ///remove
    public void Remove(int Id)
    {
        if (head == null)
        {
            return;
        }
        Node temp = head, prev = null;
        do
        {
            if (temp.id == Id)
            {
                if (prev != null)
                {
                    prev.next = temp.next;
                }
                if (temp == head)
                {
                    head = temp.next;
                }
                return;
            }
            prev = temp;
            temp = temp.next;
        } while (temp != head);
    }
}

class RoundRobin
{
    public static void Main()
    {
        Robin rr = new Robin();
        rr.AddProcess(1, 9);
        rr.AddProcess(3, 5);
        rr.Execute(1);
    }
}