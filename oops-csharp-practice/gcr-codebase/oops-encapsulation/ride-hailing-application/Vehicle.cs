public abstract class Vehicle
{
    protected int rate;
    public abstract int CalculateFare(int distance);
    public void GetVehicleDetail()
    {
        Console.WriteLine("Rate per km: " + rate);
    }
}