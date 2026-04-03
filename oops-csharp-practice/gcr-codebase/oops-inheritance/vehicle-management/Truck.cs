// Truck inherits Vehicle
public class Truck : Vehicle
{
    public int PayloadCapacity;
    //overriden method
    public override void DisplayInfo()
    {
        Console.WriteLine("Truck payload: " + PayloadCapacity);
    }
}
