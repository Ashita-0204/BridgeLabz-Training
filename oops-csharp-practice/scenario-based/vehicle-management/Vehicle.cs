using System;
class Vehicle
{
    protected string VehicleNum;
    protected int cost;

    public Vehicle(string num, int rate)
    {
        VehicleNum = num;
        cost = rate;
    }
    public void Displayy()
    {
        Console.WriteLine("Vehicle Number: " + VehicleNum);
    }
}
