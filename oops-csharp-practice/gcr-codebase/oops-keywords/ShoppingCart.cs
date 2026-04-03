using System;
class ShoppingCart
{
    //static variable
    public static double discount = 10;
    //instance variable
    public string productName;
    public double Price;
    public int Quantity;

    // readonly variable
    public readonly int productID;

    // constructor
    public ShoppingCart(string name, double price, int qty, int id)
    {
        this.productName = name;
        this.Price = price;
        this.Quantity = qty;
        this.productID = id;
    }
    // static method 
    public static void Update(double newDiscount)
    {
        discount = newDiscount;
    }

    public void Display()
    {
        if (this is ShoppingCart)
        {
            Console.WriteLine(productName + " is for Rs." + Price + " with this quantity : " + Quantity);
        }
    }

    public static void Main()
    {
        ShoppingCart cart = new ShoppingCart("Phone", 8520, 1, 63);
        Update(25);
        cart.Display();
    }

}