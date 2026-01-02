using System;
class BusDistanceTracker
{
    public static void Main()
    {
        // Variables
        int total = 0;
        int option;

        Console.WriteLine("Bus Route Distance Tracker Started");

        do
        {
            // Menu 
            Console.WriteLine("\n------ MENU ------");
            Console.WriteLine("1. Add distance at stop");
            Console.WriteLine("2. View total distance travelled");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            option = int.Parse(Console.ReadLine());

            // Switch case 
            switch (option)
            {
                case 1:  // Add distance
                    Console.Write("Enter distance covered at this stop: ");
                    int distance = int.Parse(Console.ReadLine());
                    total += distance;
                    Console.WriteLine("Distance added successfully.");
                    break;

                case 2:    // View total distance
                    Console.WriteLine("Total distance travelled: " + total + " km");
                    break;

                case 3:   // Exit
                    Console.WriteLine("\nPassenger got off the bus.");
                    Console.WriteLine("Final distance travelled: " + total + " km");
                    break;

                default:   // Invalid choice
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

        } while (option != 3);
    }
}