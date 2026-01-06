using System;
using System.ComponentModel.Design.Serialization;
public class Truck : Vehicle, IRentable
{
    public Truck(string num, int rate)
    {
        VehicleNum = num;
        cost = rate;
    }
    public int CalculateRent(int day)
    {
        return cost * day;
    }
}