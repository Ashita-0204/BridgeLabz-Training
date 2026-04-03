using System;
public class SumUntilZero
{
    public static void Main()
    {
        double total = 0.0;
        double num = double.Parse(Console.ReadLine());
        while (num != 0) //to continue till not zero
        {
            total += num;
            num = double.Parse(Console.ReadLine()); //Input again for sum
        }
        Console.WriteLine("the total sum is " + total);
    }
}