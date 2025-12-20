using System;
class DoubleOperations
{
    public static void Main(String[] args)
    {
        //Input
        Console.WriteLine("Enter the first double number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second double number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third double number: ");
        double c = double.Parse(Console.ReadLine());
        //Calculations
        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;
        Console.WriteLine("The results of Double Operations are " + result1 + " " + result2 + " " + result3 + "and " + result4);
    }
}