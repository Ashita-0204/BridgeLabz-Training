using System;

public class AccessModifier
{

    //public - accesible everywhere
    public int num1 = 50;

    //private - accessible only inside the class
    private int num2 = 90;

    //protected - accessible in this class and subclass
    protected int num3 = 80;

    //internal - accessible in this project 
    internal int num4 = 70;

    private void ShowPrivate()
    {
        Console.WriteLine("The private number is: " + num2);
    }

    public void display()
    {
        Console.WriteLine("The protected number is: " + num3);
        Console.WriteLine("The Public variable is: " + num1);
        Console.WriteLine("The internal variable is: " + num4);
        ShowPrivate();
    }

    public static void Main(String[] args)
    {
        AccessModifier var = new AccessModifier();
        var.display();
    }
}