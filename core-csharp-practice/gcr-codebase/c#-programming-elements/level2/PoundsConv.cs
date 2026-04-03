using System;
public class PoundsConv
{
    public static void Main(String[] args)
    {
        Console.Write("Enter weight in pounds: "); //input
        double pounds = double.Parse(Console.ReadLine());
        double kg = pounds / 2.2; //Conversion
        Console.WriteLine($"The weight of the person in pounds is {pounds} and in kg is {kg}");
    }
}
