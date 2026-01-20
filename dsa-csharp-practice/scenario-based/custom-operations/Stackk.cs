using System;
class Stackk
{
    Node top;

    //Push
    public void Push(int d)
    {
        Node newNode = new Node(d);
        newNode.next = top;
        top = newNode;
    }

    //Pop
    public void Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack UnderFlow");
            return;
        }
        Console.Write(top.data);
        top = top.next;
    }

    //peek
    public void Peek()
    {
        if (top == null)
        {
            Console.WriteLine("Stack UnderFlow");
            return;
        }
        Console.Write(top.data);
    }
    //Display
    public void Display()
    {
        Node temp = top;
        while (temp != null)
        {
            Console.Write(temp.data + " - ");
            temp = temp.next;
        }
        Console.WriteLine("NULL");
    }

}