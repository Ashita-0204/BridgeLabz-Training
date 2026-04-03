using System;
class Product
{
    //global variables
    public string prodName; //each prod can have its own name/price
    public int price;
    public static int totalProd = 0; //belongs to class -common for all

    //constructor w/ parameters
    public Product(string name, double price)
    {
        this.prodName = name;
        this.price = price;
        totalProd++;
    }

    //instance methods - single details
    public void Display()
    {
        Console.WriteLine("Product name " + prodName);
        Console.Write("Price " + price);
    }

    //class method 
    public static void DisplayTotal()
    {
        Console.WriteLine("Total Products " + totalProd);
    }
}

class ProductInventory
{
    public static void Main()
    {
        Product prod1 = new Product("Bags", 500);
        Product prod2 = new Product("Bottle", 200);
        prod1.Display();
        prod2.Display();
        // class method
        Product.DisplayTotal();
    }
}