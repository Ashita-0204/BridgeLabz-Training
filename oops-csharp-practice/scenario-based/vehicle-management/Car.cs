using System;
using System.ComponentModel.Design.Serialization;
class Car : Vehicle, IRentable
{
    public Car(string num, int rate)
    {
        VehicleNum = num;
        cost = rate;
    }
    public int CalculateRent(int day)
    {
        return cost * day;
    }
}