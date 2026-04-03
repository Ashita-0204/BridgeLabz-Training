using System;
using System.Diagnostics;
using System.Globalization;
class Node
{
    public int id, qty, price;
    public string name;
    public Node next;

    public Node(int iD, int quantity, int pricee, string namee)
    {
        id = iD;
        qty = quantity;
        price = pricee;
        name = namee;
        next = null;
    }
}

//InventoryUtil
class Inventory
{
    Node head;

    //Add 
    public void AddFirst(int Id, int quantity, int pricee, string namee)
    {
        Node node = new Node(Id, quantity, pricee, namee);
        node.next = head;
        head = node;
    }

    //AddLast
    public void AddLast(int iD, int quantity, int pricee, string namee)
    {
        Node node = new Node(iD, quantity, pricee);
        if (head == null)
        {
            head = node;
            return;
        }
        Node temp = head;
        if (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = node;
    }

    //Remove by ID
    public void Remove(int iD)
    {
        if (head == null)
        {
            return;
        }
        if (head.id == iD)
        {
            head = head.next;
            return;
        }
        Node temp = head;
        while (temp.next != null && temp.id != iD)
        {
            temp = temp.next;
        }
        if (temp.next != null)
        {
            temp.next = temp.next.next;
        }
    }

    //Update
    public void Update(int iD, int quantity)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.id == iD)
            {
                temp.qty = quantity;
                return;
            }
            temp = temp.next;
        }
    }
    //Search
    public void Search(string key)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.name == key || temp.id.ToString() == key)
            {
                Console.WriteLine(temp.id + " " + temp.name + " " + temp.qty + " " + temp.price);
            }
            temp.next.next;
        }
    }

    //total
    public int Total()
    {
        int sum = 0;
        Node temp = head;
        while (temp != null)
        {
            sum += temp.price * temp.qty;
            temp = temp.next;
        }
        return sum;
    }

}
class InventoryManagement
{
    public static void Main()
    {
        Inventory inv = new Inventory();
        inv.AddFirst(1, "Pen", 15, 5);
        inv.AddLast(2, "Book", 5, 100);
        inv.Update(1, 50);
        Console.WriteLine("Total Value: " + inv.Total());
    }
}