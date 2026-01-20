using System;
using System.Xml;
class Singly
{
    Node head;

    //Insert at beginning
    public void InsertFirst(int data)
    {
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;
    }

    public void InsertLast(int data)
    {
        Node newNode = new Node(data);
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

    //Delete by val
    public void Delete(int d)
    {
        if (head == null)
        {
            return;
        }
        if (head.data == d)
        {
            head = head.next;
            return;
        }
        Node temp = head;
        while (temp.next != null && temp.next.data = d)
        {
            temp = temp.next; //second last node 
        }
        if (temp.next != null)
        {
            temp.next = temp.next.next; //assigning the last val
        }
    }

    //Searching
    public bool Search(int d)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.data = d)
            {
                return true;
            }
            temp = temp.next;
        }
        return false;
    }

    //Display
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + "-");
            temp = temp.next;
        }
        Console.Write("Null");
    }
}