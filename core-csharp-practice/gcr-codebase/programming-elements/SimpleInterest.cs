using System;
public class SimpleInterest
{
    public static void Main(String[] args)
    {
        int principle = int.Parse(Console.ReadLine());
        int rate = int.Parse(Console.ReadLine());
        int time = int.Parse(Console.ReadLine());
        int formula = (principle * rate * time) / 100;
        Console.WriteLine("The simple interest is " + formula);
    }
}