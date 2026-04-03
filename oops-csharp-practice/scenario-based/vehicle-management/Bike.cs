using System;
using System.ComponentModel.Design.Serialization;
class Bike : Vehicle, IRentable
{
    public Bike(string num, int rate)
    {
        VehicleNum = num;
        cost = rate;
    }
    public int CalculateRent(int day)
    {
        return cost * day;
    }
}