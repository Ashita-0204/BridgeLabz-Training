using System;
using System.Runtime.Intrinsics;
using System.Text;
class Vehicle
{
    //instance variable
    public string owner;
    public string type;
    //class variable
    public static int fees = 6000;
    //constructor
    public Vehicle(string Owner, string Type)
    {
        owner = Owner;
        type = Type;
    }
    // Instance method
    public void Display()
    {
        Console.WriteLine("Owner Name: " + owner);
        Console.WriteLine("Vehicle Type: " + type);
        Console.WriteLine("Registration Fee: " + fees);
    }

    // Class method
    public static void Update(int fee)
    {
        fees = fee;
    }
}
class VehicleRegistration
{
    public static void Main()
    {
        Vehicle vehicle = new Vehicle("Sneha", "Alto");
        vehicle.Display();
        Vehicle.Update(5000);
        vehicle.Display();
    }
}