using System;
public class SimpleInterest
{
    public static void Main(String[] args)
    {
        //input
        Console.Write("Enter principal: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter rate: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter time: ");
        double time = double.Parse(Console.ReadLine());
        //Formula
        double si = (principal * rate * time) / 100;
        Console.WriteLine($"The Simple Interest is {si} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
}
