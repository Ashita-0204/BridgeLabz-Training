using System;
class Income
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the salary: "); //Input
        double salary = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the bonus: ");
        double bonus = double.Parse(Console.ReadLine());
        double totalIncome = salary + bonus; //Calculative formula
        Console.WriteLine("The salary is INR " + salary + "and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);

    }
}