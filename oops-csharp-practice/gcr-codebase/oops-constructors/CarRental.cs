using System;
class Rental
{
    //variables
    public string name;
    public string model;
    public int days;
    public int cost = 1500;

    // Parameterized constructor
    public Rental(string name, string model, int days)
    {
        this.name = name;
        this.model = model;
        this.days = days;
    }

    // Method to calculate total cost
    public int TotalCost()
    {
        return days * cost;
    }

    public void Display()
    {
        Console.WriteLine(name + " owns " + model);
        Console.WriteLine("Days: " + days);
        Console.WriteLine("Total Cost: " + TotalCost());
    }
}

class CarRental
{
    public static void Main()
    {
        Rental car = new Rental("Paroah", "Alto", 8);
        car.Display();
    }
}
