// Inherits from Shipped
class Delivered : Shipped
{
    // Delivery date of the order
    public string DeliveryDate;

    // Method to get the order status
    public string GetOrderStatus()
    {
        return ("Order delivered on " + DeliveryDate);
    }
}
