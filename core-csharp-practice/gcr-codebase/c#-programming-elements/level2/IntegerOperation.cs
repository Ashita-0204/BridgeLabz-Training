using System;
class IntegerOperations
{
    public static void Main(String[] args)
    {
        //Input
        Console.WriteLine("Enter the first integer: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third integer: ");
        int c = int.Parse(Console.ReadLine());
        //Calculation
        int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;
        Console.WriteLine("The results of Int Operations are " + result1 + " " + result2 + " " + result3 + "and " + result4);
    }
}