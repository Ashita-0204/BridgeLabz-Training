// using namespace RotationbyK

// {
using System;
class Singly
{
    Node? head;
    public void AddLast(int d)
    {
        Node newNode = new Node(d);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;

    }


    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " - ");
            temp = temp.next;
        }
        // Console.WriteLine("Null");
    }
    public void Rotate(int k)
    {
        if (head == null || head.next == null || k == 0)
        {
            Console.Write("Invalid");
            return;
        }
        Node curr = head;
        int len = 1;
        while (curr.next != null)
        {
            curr = curr.next;
            len++; //length stored
        }
        k = k % len;
        if (k == 0)
        {
            return;
        }
        curr.next = head; //circular
        Node newTail = head;
        for (int i = 1; i < k; i++) //rotation till k
        {
            newTail = newTail.next;
        }
        head = newTail.next;
        newTail.next = null;
        // Singly.Display();

    }


}
// }


