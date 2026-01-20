using System;
class Queuee
{
    Node front, rear;

    //enq
    public void Enqueue()
    {
        Node newNode = new Node(d);
        if (rear == null)
        {
            front = rear = newNode;
            return;
        }
        rear.next = newNode;
        rear = newNode;
    }

    //Deq
    public void Dequeue()
    {
        if (front == null)
        {
            Console.Write("Queue  Underflow");
            return;
        }
        Console.WriteLine("Removed: " + front.data);
        front = front.next;//revaluing

        if (front == null)
        {
            rear = null;
        }

    }

    //peek
    public void Peek()
    {
        if (front == null)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }
        Console.WriteLine("Front: " + front.data);
    }
    // Display
    public void Display()
    {
        QueueNode temp = front;
        while (temp != null)
        {
            Console.Write(temp.data + " - ");
            temp = temp.next;
        }
        Console.WriteLine("NULL");
    }
}