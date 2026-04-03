class Node
{
    public int data;
    public string str;
    public Node next, prev;

    public Node(int Data, string Str)
    {
        this.data = Data;
        this.str = Str;
        this.next = null;
        this.prev = null;
    }
}