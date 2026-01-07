using System.Net.NetworkInformation;

public class VegItem : FoodItem, IDiscountable
{
    public VegItem(int pricee, int quantity)
    {
        price = pricee;
        qty = quantity;
    }
    public override int CalculateTotal()
    {
        return price * qty;
    }
    public int ApplyDiscount()
    {
        return 15;
    }
    public string GetDiscountDetail()
    {
        return "15 Percent discount";
    }
}