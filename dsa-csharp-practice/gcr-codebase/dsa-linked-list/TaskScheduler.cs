using System;
using System.Net.NetworkInformation;

class Node
{ //Node Class
    public int iD, priority;
    public string name, due;
    public Node next;

    public Node(int id, string prior, string namee, string duee)
    {
        iD = id;
        name = namee;
        priority = prior;
        due = duee;
        next = null;
    }
}
//Task Scheduler
class Schedulerr
{
    Node head;
    //Add Task
    public void AddFirst(int id, int namee, string duee, string prior)
    {
        Node node = new Node(id, prior, namee, duee);
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

    //Remove
    public void Remove(int id)
    {
        if (head == null)
        {
            return;
        }
        Node temp = head, prev = null;
        do
        {
            if (temp.iD == id)
            {
                if (temp != null)
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
            temp = temp = temp.next;
        } while (temp != head);
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
            Console.WriteLine(temp.iD + " " + temp.name);
            temp = temp.next;
        } while (temp != head);
    }
}

class TaskScheduler
{
    public static void Main()
    {
        Schedulerr task = new Schedulerr();
        task.AddFirst(1, "Lunch", "Evening", 1);
        task.AddFirst(2, "Assignment", "Today", 2);
        task.Display();
    }
}