class BrowserBuddy : IBrowserBuddy
{
    private HistoryNode head;
    private HistoryNode current;

    // Stack for closed tabs (each tab stores its history head)
    private Stack<HistoryNode> closedTabs = new Stack<HistoryNode>();

    public void Visit(string url)
    {
        HistoryNode node = new HistoryNode(url);

        if (head == null)
        {
            head = current = node;
        }
        else
        {
            current.Next = node;
            node.Prev = current;
            current = node;
        }

        Console.WriteLine("Visited: " + url);
    }

    public void Back()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Back to: " + current.Url);
        }
        else
        {
            Console.WriteLine("No previous page");
        }
    }

    public void Forward()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Forward to: " + current.Url);
        }
        else
        {
            Console.WriteLine("No next page");
        }
    }

    public void CloseTab()
    {
        if (head != null)
        {
            closedTabs.Push(head);
            head = current = null;
            Console.WriteLine("Tab closed");
        }
    }

    public void ReopenTab()
    {
        if (closedTabs.Count > 0)
        {
            head = closedTabs.Pop();

            // Move current to last visited page
            current = head;
            while (current.Next != null)
                current = current.Next;

            Console.WriteLine("Tab reopened");
        }
        else
        {
            Console.WriteLine("No closed tabs");
        }
    }

    public string GetCurrentPage()
    {
        return current != null ? current.Url : "No page open";
    }
}
