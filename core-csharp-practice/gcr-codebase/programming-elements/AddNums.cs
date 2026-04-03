using System;

public class AddNums
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the numbers");
        int n = int.Parse(Console.ReadLine()); //Input 1
        int m = int.Parse(Console.ReadLine()); //Input 2
        int sum = n + m;
        //Printing in next Line
        Console.WriteLine("The sum of two numbers is " + sum);

    }
}