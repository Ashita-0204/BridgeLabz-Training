using System;
class Program
{
    public static void Main()
    {
        // Polymorphism
        Vehicle[] vehicles =
        {
            new Car { SeatCapacity = 4 },
            new Truck { PayloadCapacity = 3000 },
            new Motorcycle { HasSidecar = false }
        };

        foreach (Vehicle i in vehicles)
        {
            i.DisplayInfo();
        }
    }
}
