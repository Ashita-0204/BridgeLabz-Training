// Base class 
public class Vehicle
{
    //variable
    public int MaxSpeed;
    public string FuelType;

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Vehicle information");
    }
}
