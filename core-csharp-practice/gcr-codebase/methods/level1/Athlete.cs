using System;
using System.Diagnostics;
class Athlete
{
    public static int Rounds(int perimeter) //method to calc nuber of rounds
    {
        int rounds = 5000 / perimeter;
        return rounds;
    }
    public static void Main()
    {
        //Sides input
        Console.Write("Side 1");
        int side1 = int.Parse(Console.ReadLine());
        Console.Write("Side 2");
        int side2 = int.Parse(Console.ReadLine());
        Console.Write("Side 3");
        int side3 = int.Parse(Console.ReadLine());
        //calculating Perimeter
        int perimeter = side1 + side2 + side3;
        int ans = Rounds(perimeter);
        //printing statement
        Console.WriteLine("The number of rounds are " + ans);
    }
}