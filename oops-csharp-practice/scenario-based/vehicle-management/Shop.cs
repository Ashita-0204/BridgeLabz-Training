using System;
class Shop
{
    public static void Main()
    {
        int option;
        do
        {
            Console.WriteLine("Vehicle Rental System");
            Console.WriteLine("1. Rent Bike");
            Console.WriteLine("2. Rent Car");
            Console.WriteLine("3. Rent Truck");
            Console.WriteLine("4. Exit");

            option = int.Parse(Console.ReadLine());

            // If renting a vehicle
            if (option >= 1 && option <= 3)
            {
                Console.Write("Enter Customer Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Vehicle Number: ");
                string vno = Console.ReadLine();

                Console.Write("Enter Rate Per Day: ");
                int rate = int.Parse(Console.ReadLine());

                Console.Write("Enter Days: ");
                int day = int.Parse(Console.ReadLine());

                Customer cust = new Customer(name);
                IRentable rent = null;

                // Select vehicle type
                if (option == 1)
                {
                    rent = new Bike(vno, rate);
                }
                else if (option == 2)
                {
                    rent = new Car(vno, rate);
                }
                else if (option == 3)
                {
                    rent = new Truck(vno, rate);
                }
                cust.Displayy(); // show customer
                Console.WriteLine("Total Rent: " + rent.CalculateRent(day)); // show rent
            }
        } while (option != 4);
        Console.WriteLine("Thank You");
    }
}