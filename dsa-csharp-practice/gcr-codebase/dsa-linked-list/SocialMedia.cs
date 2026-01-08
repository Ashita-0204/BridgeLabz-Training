using System;
class Node
{
    public int UserId, age;
    public string name;

    public Node next;
    public Node Friend;

    public Node(int id, string namee, int agee)
    {
        UserId = id;
        name = namee;
        age = agee;
        next = null;
        Friend = null;
    }
}

class Media
{
    Node head;
    //Add user
    public void AddUser(int id, string namee, int agee)
    {
        Node node = new Node(id, namee, agee);
        node.Next = head;
        head = node;
    }
    // Find user
    Node FindUser(int id)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.UserId == id)
            {
                return temp;
            }
            temp = temp.next;
        }
        return null;
    }

    // Add friend connection 
    public void AddFriend(int id1, int id2)
    {
        Node user1 = FindUser(id1);
        Node user2 = FindUser(id2);

        if (user1 == null || user2 == null)
        {
            return;
        }
        Node f1 = new Node(id2, "", 0);
        f1.Friend = user1.Friend;
        user1.Friend = f1;
    }

    // Display
    public void Display(int id)
    {
        Node user = FindUser(id);
        if (user == null)
        {
            return;
        }
        Console.WriteLine("Friends of " + user.name + ":");
        Node temp = user.Friend;
        while (temp != null)
        {
            Console.WriteLine("Friend ID: " + temp.UserId);
            temp = temp.Friend;
        }
    }

    // Count 
    public void Count()
    {
        Node temp = head;
        while (temp != null)
        {
            int count = 0;
            Node friend = temp.Friend;
            while (friend != null)
            {
                count++;
                friend = friend.Friend;
            }
            Console.WriteLine(temp.Name + " has " + count + " friends");
            temp = temp.Next;
        }
    }
}
class SocialMedia
{
    public static void Main()
    {
        Media media = new Media();

        media.AddUser(1, "Sneha", 20);
        media.AddUser(2, "Keshi", 21);
        media.AddUser(3, "Rea", 22);
        media.AddFriend(1, 2);
        media.AddFriend(1, 3);
        media.Display(1);
        media.Count();
    }
}