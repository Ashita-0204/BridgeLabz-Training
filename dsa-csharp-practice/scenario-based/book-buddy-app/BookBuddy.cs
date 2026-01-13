using System;
class BookBuddy
{
    public static void Main()
    {
        Console.WriteLine("Enter the size of shelf");
        int size = int.Parse(Console.ReadLine());

        IShelf shelf = new IShelf(size);
        int choice;
        do
        {
            Console.WriteLine("===== BookBuddy Menu =====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Sort Books");
            Console.WriteLine("3. Search by Author");
            Console.WriteLine("4. Export Books");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    shelf.AddBooks();
                    break;
                case 2:
                    shelf.sortBooks();
                    break;

                case 3:
                    if (!shelf.SearchByAuthor(searchAuthor))
                        Console.WriteLine("No books found for this author.");
                    break;

                case 4:
                    shelf.ExportBooks();
                    break;

                case 5:
                    Console.WriteLine("Exiting BookBuddy...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}