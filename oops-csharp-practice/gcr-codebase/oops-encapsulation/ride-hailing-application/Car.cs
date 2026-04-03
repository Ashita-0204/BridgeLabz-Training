public class Car : Vehicle, IGPS
{
    public Car()
    {
        rate = 18;
    }

    public override double CalculateFare(int distance)
    {
        return rate * distance;
    }

    public string GetCurrLocation()
    {
        return "Square Office";
    }

    public void UpdateLocation(string location)
    {
        Console.WriteLine("Location updated");
    }
}