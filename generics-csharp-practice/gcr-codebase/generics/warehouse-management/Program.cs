class Program
{
    public static void Main()
    {
        Console.Write("Enter electronics count: ");
        int c = int.Parse(Console.ReadLine());
        Storage<Electronics> electronic = new Storage<Electronics>(c);

        for (int i = 0; i < c; i++)
        {
            Console.Write("Enter electronics name: ");
            electronic.AddItem(new Electronics { Name = Console.ReadLine() });
        }

        Console.WriteLine("\nStored Items:");
        electronic.DisplayItems();
    }
}