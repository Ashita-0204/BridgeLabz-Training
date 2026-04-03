public abstract class FoodItem
{
    protected int price;
    protected int qty;
    public abstract int CalculateTotal();
    public void GetItemDetail()
    {
        Console.WriteLine("Quantity: " + qty);
    }
}