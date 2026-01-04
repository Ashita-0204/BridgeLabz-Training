using System;
class Ordered
{
    public static void Main()
    {

        Delivered order = new Delivered
        {
            // Calling the base class constructor
            OrderId = 101,
            OrderDate = "02-Jan-2026",
            TrackingNumber = "PCK7123",
            DeliveryDate = "06-Jan-2026"
        };

        // Calling the derived class method
        Console.WriteLine(order.GetOrderStatus());
    }
}
