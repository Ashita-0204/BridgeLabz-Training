using System;

class Scheduler
{
    public static void Main()
    {

        ICinema manager = new Cinema();
        int choice;

        do
        {
            Console.WriteLine("===== CinemaTime Menu =====");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Search Movie");
            Console.WriteLine("3. Display All Movies");
            Console.WriteLine("4. Generate Report");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.AddMovie();
                    break;

                case 2:

                    bool found = manager.searchMovie(keyword);
                    if (!found)
                        Console.WriteLine("Movie not found.");
                    break;

                case 3:
                    Console.WriteLine("--- All Movies ---");
                    manager.DisplayAllMovies();
                    break;

                case 4:
                    manager.GenerateReport();
                    break;

                case 5:
                    Console.WriteLine("Exiting..");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        } while (choice != 5);
    }
}
