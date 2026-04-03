using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

//Node class
class Node
{
    public int rollnum;
    public string name;
    public int age;
    public char grade;
    public Node next;

    public Node(int roll, string namee, int agee, char g)
    {
        rollnum = roll;
        name = namee;
        age = agee;
        grade = g;
        next = null;
    }
}

class StudList
{
    Node head;

    //Add first
    public void AddFirst(int roll, string namee, int agee, char g)
    {
        Node node = new Node(roll, namee, agee, g);
        node.next(head);
        head = node;
    }
    //Add last
    public void AddLast(int roll, string namee, int agee, char g)
    {
        Node node = new Node(roll, namee, agee, g);
        if (head == null)
        {
            head = null;
            return;
        }
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = node;
    }
    //Delete
    public void Delete(int roll)
    {
        if (head == null)
        {
            return;
        }
        if (head.rollnum == roll)
        {
            head = head.next;
            return;
        }
        Node temp = head;
        while (temp.next != null && temp.next.rollnum != roll)
        {
            temp = temp.next;
        }
        if (temp.next != null)
        {
            temp.next = temp.next.next;
        }
    }
    public void UpgrageGrade(int roll, char g)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.rollnum == roll)
            {
                temp.grade = g;
                return;
            }
            temp = temp.next;
        }
    }

    public void Search(int roll)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.rollnum == roll)
            {
                Console.WriteLine("The result of search is " + temp.rollnum + " " + temp.name + " " + temp.age + " " + temp.grade);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Student not found");
    }

    //Display
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.rollnum + " " + temp.name + " " + temp.age + " " + temp.grade);
            temp = temp.next;
        }
    }
}

class StudentRecord
{
    public static void Main()
    {
        StudList student = new StudList();
        student.AddFirst(1, "Ashi", 21, 'A');
        student.AddLast(4, "Karthik", 23, 'D');
        student.UpgrageGrade(4, 'C');
        student.Display();
    }
}

