public abstract class Product
{
    private int prodId;
    private string name;
    protected double price;

    public int prodId
    {
        set => prodId = value;
    }
    public string Name
    {
        set => name = value;
    }

    public abstract int CalculateDiscount();
}