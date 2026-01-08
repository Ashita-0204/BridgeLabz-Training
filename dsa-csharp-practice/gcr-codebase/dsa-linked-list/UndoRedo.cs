using System;
class Node
{
    public string content;
    Node prev, next;
    public Node(string Content)
    {
        content = Content;
        next = null;
        prev = null;
    }
}
//methods
class Editor
{
    Node temp;
    int count = 0, limit = 10;

    //Add
    public void AddText(string Content)
    {
        Node node = new Node(Content);
        if (temp != null)
        {
            temp.next = node;
            node.prev = temp;
        }
        temp = node;
        count++;
    }
    //undo
    public void Undo()
    {
        if (temp.prev != null && temp != null)
        {
            temp = temp.prev;
        }
    }

    //redo
    public void Redo()
    {
        if (temp.next != null && temp != null)
        {
            temp = temp.next;
        }
    }
    public void Display()
    {
        if (temp != null)
        {
            Console.WriteLine("Current Text: " + temp.content);
        }
    }
}
class UndoRedo
{
    public static void Main()
    {
        Editor text = new Editor();
        text.AddText("Hello");
        text.AddText("Hello World");
        text.Undo();
        text.Display();
    }
}