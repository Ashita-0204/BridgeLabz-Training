using System;
// Car inherits Vehicle
public class Car : Vehicle
{
    public int SeatCapacity;
    //overriden class
    public override void DisplayInfo()
    {
        Console.WriteLine("Car seats: " + SeatCapacity);
    }
}
