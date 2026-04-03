using System;
using System.Collections.Generic;
class QueueViaStack
{
    Stack<int> stackEnqueue = new Stack<int>();
    Stack<int> deQueue = new Stack<int>();

    //enqueue
    public void Enqueue(int x)
    {
        stackEnqueue.Push(x);
    }
    //dequeue
    public void Dequeue(int x)
    {
        if (deQueue.Count == 0)
        {
            while (stackEnqueue.Count > 0)
            {
                deQueue.Push(stackEnqueue.Pop());
            }
        }
        return deQueue.Pop();
    }

    public static void Main()
    {
        QueueViaStack q = new QueueViaStack();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());
    }
}